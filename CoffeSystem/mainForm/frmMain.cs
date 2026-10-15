using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Repositories;
using CoffeSystem_Business;
using CoffeSystem_1UI.Screens;
using System.Windows.Forms.DataVisualization.Charting;
using CoffeSystem_1UI.Screens.Users;
using CoffeSystem_1UI.Screens.Reports;
using CoffeSystem_1UI.Screens.Settings;
namespace CoffeSystem_1UI.mainForm
{
    public partial class frmMain : Form
    {
        private Chart? _salesChart;
        private readonly DashboardService _dashboardService;
        private readonly OrderService _orderService;
        private readonly Form _loginForm;
        private readonly string _loggedInUserName;
        private bool _isClosing = false;
        private readonly string _loggedInUserRole;
        private readonly int _loggedInUserId;
        public frmMain(Form loginForm, int loggedInUserId, string loggedInUserName, string loggedInUserRole)
        {
            InitializeComponent();
            ConfigureRecentOrdersGrid();
            _loginForm = loginForm;
            _loggedInUserName = loggedInUserName;
            _loggedInUserRole = loggedInUserRole;
            _loggedInUserId = loggedInUserId;
            ApplyRolePermissions();

            _orderService = CreateOrderService();

            InitializeSalesChart();
            AppDbContext context = new AppDbContext();

            DahboardRepositry dahboardRepositry = new DahboardRepositry(context);
            CafeSettingsRepository settingsRepository = new CafeSettingsRepository(context);
            _dashboardService = new DashboardService(dahboardRepositry, settingsRepository);
        }

        // Onactive Methode
        protected override async void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            try
            {
                await RefreshDashboardAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to refresh dashboard.\n{ex.Message}",
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // Methode : Create Order Service
        private OrderService CreateOrderService()
        {
            AppDbContext context = new AppDbContext();

            OrderRepository orderRepository =
                new OrderRepository(context);

            return new OrderService(orderRepository);
        }

        // Methode : Building Chart Compoenents
        private void InitializeSalesChart()
        {
            _salesChart = new Chart();

            _salesChart.Dock = DockStyle.Fill;
            _salesChart.BackColor = Color.White;
            _salesChart.BorderlineWidth = 0;

            _salesChart.ChartAreas.Add("MainArea");

            ChartArea area = _salesChart.ChartAreas["MainArea"];

            area.AxisX.Title = "Date";
            area.AxisY.Title = "Revenue (DT)";

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            // Automatically scale the Revenue axis
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = double.NaN;
            area.AxisY.Interval = 0;

            _salesChart.Legends.Clear();

            pnlSalesChar.Controls.Add(_salesChart);
        }
        // Methode N°1
        public async Task LoadDashboardDataAsync()
        {
            // Ensure the grid has columns before adding rows
            if (dgvRecentOrders.Columns.Count == 0)
            {
                ConfigureRecentOrdersGrid();
            }
            decimal revenue = _dashboardService.GetTodayRevenue();
            lblRevenueValue.Text = $"{revenue:0.000} DT";
            // Low Stock
            int lowStock = await _dashboardService.GetLowStockAsync();
            lblLowStockValue.Text = lowStock.ToString();

            // Today's Orders
            int orders = _dashboardService.GetTodayOrders();
            lblOrdersValue.Text = orders.ToString();

            // Total Products
            int products = _dashboardService.GetTotalProducts();
            lblProductsValue.Text = products.ToString();


            // Recent Orders
            var recentOrders = _dashboardService.GetRecentOrders(5);

            // Ensure columns exist immediately before adding rows
            if (dgvRecentOrders.Columns.Count == 0)
            {
                ConfigureRecentOrdersGrid();
            }

            if (dgvRecentOrders.Columns.Count == 0)
            {
                throw new InvalidOperationException(
                    "Recent Orders columns were not initialized.");
            }

            dgvRecentOrders.Rows.Clear();

            foreach (var order in recentOrders)
            {
                dgvRecentOrders.Rows.Add(
                    order.OrderId,
                    order.OrderDate.ToString("dd/MM/yyyy HH:mm"),
                    $"{order.TotalAmount:0.000} DT",
                    "Completed",
                    order.PaymentMethod
                );
            }
            lblUser.Text = _loggedInUserName+ "👤";

        }


        // Methode N°2

        private void ConfigureRecentOrdersGrid()
        {
            dgvRecentOrders.Columns.Clear();

            dgvRecentOrders.AutoGenerateColumns = false;
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.MultiSelect = false;

            dgvRecentOrders.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvRecentOrders.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Column 1: Order ID
            dgvRecentOrders.Columns.Add(
                "colOrderId",
                "Order ID");

            // Column 2: Order Date
            dgvRecentOrders.Columns.Add(
                "colOrderDate",
                "Order Date");

            // Column 3: Total Amount
            dgvRecentOrders.Columns.Add(
                "colTotalAmount",
                "Total Amount");

            // Column 4: Status
            dgvRecentOrders.Columns.Add(
                "colStatus",
                "Status");

            // Column 5: Payment Method
            dgvRecentOrders.Columns.Add(
                "colPaymentMethod",
                "Payment Method");
        }




        // Methode N°3 : Get revenus by day last 7 days

        private async Task LoadSalesChart()
        {
            List<(DateTime Date, decimal Revenue)> data =
                await _orderService.GetLast7DaysRevenueAsync();

            Series series = new Series("Revenue");

            series.ChartType = SeriesChartType.Line;
            series.BorderWidth = 3;
            series.MarkerStyle = MarkerStyle.Circle;
            series.MarkerSize = 8;

            foreach (var item in data)
            {
                series.Points.AddXY(
                    item.Date.ToString("dd/MM"),
                    Convert.ToDouble(item.Revenue)
                );
            }

            _salesChart.Series.Clear();
            _salesChart.Series.Add(series);

            // Get the highest daily revenue
            double maxRevenue = data.Count > 0
                ? data.Max(item => Convert.ToDouble(item.Revenue))
                : 0;

            // Calculate a suitable maximum for the Y-axis
            double axisMaximum = maxRevenue <= 0
                ? 20
                : Math.Ceiling((maxRevenue * 1.15) / 20.0) * 20.0;

            // Configure the Revenue axis
            ChartArea area = _salesChart.ChartAreas["MainArea"];

            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = axisMaximum;

            area.AxisY.Interval = axisMaximum <= 200
                ? 20
                : axisMaximum <= 500
                    ? 50
                    : 100;

            // Refresh the chart
            area.RecalculateAxesScale();
            _salesChart.Invalidate();
        }

        // Methode N°4 : Refresh MainForm

        private async Task RefreshDashboardAsync()
        {
            if (_isClosing || IsDisposed || Disposing)
                return;

            await LoadDashboardDataAsync();

            // Check again because the form may have started closing
            // while waiting for the database.
            if (_isClosing || IsDisposed || Disposing)
                return;

            if (_salesChart == null || _salesChart.IsDisposed)
                return;

            LoadSalesChart();
        }

        // Methode N°5 : Permisson User
        private void ApplyRolePermissions()
        {
            bool isAdmin = string.Equals(
                _loggedInUserRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase
            );

            bool isCashier = string.Equals(
                _loggedInUserRole,
                "Cashier",
                StringComparison.OrdinalIgnoreCase
            );

            // Dashboard
            btnDashboard.Enabled = isAdmin || isCashier;

            // POS
            btnPOS.Enabled = isAdmin || isCashier;

            // Products
            btnProducts.Enabled = isAdmin;

            // Categories
            btnCategories.Enabled = isAdmin;

            // Orders
            btnOrders.Enabled = isAdmin || isCashier;

            // Reports
            btnReports.Enabled = isAdmin || isCashier; ;

            // Users
            btnUsers.Enabled = isAdmin;

            // Settings
            btnSettings.Enabled = isAdmin;

            // Logout is available for everyone
            btnLogout.Enabled = true;
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblPageTitle.Text = "Dashboard";
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            frmPOS posFrm = new frmPOS(_loggedInUserId);
            posFrm.ShowDialog();

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            // Check user permissions
            if (!string.Equals(
                _loggedInUserRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You don't have permission to access Products.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Open Products form
            frmProducts prodFfrm = new frmProducts();
            prodFfrm.ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {

            // Check user permissions
            if (!string.Equals(
                _loggedInUserRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You don't have permission to access Categories.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Open Categories form
            frmCategories catFrm = new frmCategories();
            catFrm.ShowDialog();

        }


        private void btnOrders_Click(object sender, EventArgs e)
        {
            //lblPageTitle.Text = "Orders";
            frmOrders frm = new frmOrders();
            frm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm = new frmReports();
            frm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Check user permissions
            if (!string.Equals(
                _loggedInUserRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You don't have permission to access Users.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Open Users form
            frmUsers frm = new frmUsers(_loggedInUserId,_loggedInUserRole);
            frm.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            // Check user permissions
            if (!string.Equals(
                _loggedInUserRole,
                "Admin",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You don't have permission to access Settings.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Open Settings form
            frmSettings frm = new frmSettings();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            _isClosing = true;

            _loginForm.Show();
            _loginForm.Activate();

            this.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlLowStock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

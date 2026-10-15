
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmOrders : Form
    {
        private readonly OrderService _orderService;

        // Keep orders in memory for search and filtering
        private List<Order> _allOrders = new List<Order>();

        private bool _isClearingFilters;

        public frmOrders()
        {
            InitializeComponent();

            _orderService = CreateOrderService();

            ConfigureDataGrid();
            LoadPaymentMethods();

            chkAllDates.Checked = true;
            dtpDate.Enabled = !chkAllDates.Checked;

            // Initial loading is handled by frmOrders_Load.
            // Keep existing Designer event bindings; do not bind them twice.
        }

        // Methode N°1
        private void ConfigureDataGrid()
        {
            dgvOrders.AutoGenerateColumns = false;

            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ReadOnly = true;

            dgvOrders.RowHeadersVisible = false;

            dgvOrders.MultiSelect = false;
            dgvOrders.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;

            dgvOrders.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvOrders.GridColor = Color.LightGray;

            dgvOrders.ColumnHeadersHeight = 40;

            // Header
            dgvOrders.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvOrders.ColumnHeadersDefaultCellStyle.BackColor =
                Color.White;

            dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(60, 60, 60);

            // Cells
            dgvOrders.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvOrders.DefaultCellStyle.BackColor =
                Color.White;

            dgvOrders.DefaultCellStyle.ForeColor =
                Color.FromArgb(60, 60, 60);

            // Selection
            dgvOrders.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(239, 235, 233);

            dgvOrders.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(60, 60, 60);

            // Columns
            dgvOrders.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private OrderService CreateOrderService()
        {
            AppDbContext context = new AppDbContext();

            OrderRepository repository =
                new OrderRepository(context);

            return new OrderService(repository);
        }

        // Methode N°2 : Load Orders Asynchronously
        private async Task LoadOrdersAsync()
        {
            _allOrders = await _orderService.GetAllOrdersAsync();

            ApplyFilters();
        }

        // Load orders when the form opens
        private async void frmOrders_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadOrdersAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل الطلبات. حاول مجددًا.",
                    "Orders Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Methode N°3 : Load Payment Methods
        private void LoadPaymentMethods()
        {
            cmbPayment.Items.Clear();

            cmbPayment.Items.Add("All Payments");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Card");

            cmbPayment.SelectedIndex = 0;
        }

        // Get the cashier name safely
        private string GetCashierDisplayName(Order order)
        {
            if (order.User == null)
                return "Unknown";

            if (!string.IsNullOrWhiteSpace(order.User.FullName))
                return order.User.FullName;

            return order.User.UserName ?? "Unknown";
        }

        // Methode N°4 : Filter Handler
        // Search by ID + filter by payment + date
        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.Trim();

            string payment =
                cmbPayment.SelectedItem?.ToString() ?? "All Payments";

            DateTime selectedDate = dtpDate.Value.Date;

            var filteredOrders = _allOrders
                .Where(order =>
                {
                    bool matchesSearch =
                        string.IsNullOrWhiteSpace(searchText) ||
                        order.OrderId.ToString().Contains(searchText);

                    bool matchesPayment =
                        payment == "All Payments" ||
                        order.PaymentMethod == payment;

                    bool matchesDate =
                        chkAllDates.Checked ||
                        order.OrderDate.Date == selectedDate;

                    return matchesSearch &&
                           matchesPayment &&
                           matchesDate;
                })
                .OrderByDescending(order => order.OrderDate)
                .ToList();

            dgvOrders.Rows.Clear();

            foreach (Order order in filteredOrders)
            {
                dgvOrders.Rows.Add(
                    order.OrderId,
                    order.OrderDate.ToString("dd/MM/yyyy HH:mm"),
                    $"{order.TotalAmount:0.000} DT",
                    order.PaymentMethod,
                    GetCashierDisplayName(order)
                );
            }
        }

        private void dgvOrders_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Live search by Order ID
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        // Filter by selected date
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        // Filter by payment method
        private void cmbPayment_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        // Clear all filters
        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            _isClearingFilters = true;

            try
            {
                txtSearch.Clear();

                if (cmbPayment.Items.Count > 0)
                {
                    cmbPayment.SelectedIndex = 0;
                }

                chkAllDates.Checked = true;
                dtpDate.Enabled = false;
            }
            finally
            {
                _isClearingFilters = false;
            }

            ApplyFilters();
        }

        // Enable or disable date filter
        private void chkAllDates_CheckedChanged(
            object sender,
            EventArgs e)
        {
            dtpDate.Enabled = !chkAllDates.Checked;

            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        private void dgvOrders_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void dgvOrders_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView.HitTestInfo hit =
                    dgvOrders.HitTest(e.X, e.Y);

                if (hit.RowIndex >= 0)
                {
                    dgvOrders.ClearSelection();

                    dgvOrders.Rows[hit.RowIndex].Selected = true;
                }
            }
        }

        private void btnViewDetail_DoubleClick(
            object sender,
            EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
                return;

            int orderId = Convert.ToInt32(
                dgvOrders.SelectedRows[0]
                    .Cells["colOrderId"]
                    .Value
            );

            MessageBox.Show($"Selected Order ID: {orderId}");
        }

        // View Order Details Asynchronously
        private async void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count == 0)
                return;

            int orderId = Convert.ToInt32(
                dgvOrders.SelectedRows[0]
                    .Cells["colOrderId"]
                    .Value
            );

            btnViewDetail.Enabled = false;

            try
            {
                Order? order =
                    await _orderService.GetOrderByIdAsync(orderId);

                if (order == null)
                {
                    MessageBox.Show(
                        "Order not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                using (frmOrderDetails form = new frmOrderDetails(order))
                {
                    form.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل تفاصيل الطلب.",
                    "Orders Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnViewDetail.Enabled = true;
                }
            }
        }
    }
}

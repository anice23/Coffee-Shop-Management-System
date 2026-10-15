using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Repositories;
using CoffeSystem_DataAccess.DTO_Reports;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CoffeSystem_DataAccess.DTO_Reports;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeSystem_1UI.Screens.Reports
{
    public partial class frmReports : Form
    {
        private readonly AppDbContext _context;
        private readonly ReportService _reportService;
        private Chart? _salesChart;
        private Chart? _paymentChart;
        private bool _isUpdatingPeriodDates = false;
        private bool _isGeneratingReport;

        public frmReports()
        {
            InitializeComponent();
            InitializeSalesChart();
            InitializePaymentChart();
            _context = new AppDbContext();
            _reportService = CreateReportService();

            cmbPeriod.Items.Clear();
            cmbPeriod.Items.AddRange(new object[]
            {
               "Today",
               "This Week",
               "This Month",
               "Custom Range"
            });

            cmbPeriod.SelectedIndex = 0;
        }



        // Methode N°1
        private ReportService CreateReportService()
        {
            ReportRepository reportRepository =
                new ReportRepository(_context);

            return new ReportService(reportRepository);
        }

        // Methode N°2

        private void InitializeSalesChart()
        {
            _salesChart = new Chart();

            _salesChart.Dock = DockStyle.None;
            _salesChart.Location = new Point(0, 40);

            _salesChart.Size = new Size(
                Math.Max(1, pnlSalesChart.ClientSize.Width),
                Math.Max(1, pnlSalesChart.ClientSize.Height - 40)
            );

            _salesChart.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            _salesChart.Margin = Padding.Empty;
            _salesChart.BackColor = Color.White;
            _salesChart.BorderlineWidth = 0;

            ChartArea area = new ChartArea("MainArea");

            area.BackColor = Color.White;

            area.AxisX.Title = "Date";
            area.AxisY.Title = "Revenue (DT)";

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.LightGray;

            // Automatic Y-axis scaling
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = double.NaN;
            area.AxisY.Interval = double.NaN;
            area.AxisY.IsStartedFromZero = true;

            // Keep labels readable
            area.AxisY.LabelStyle.Format = "N0";
            area.AxisX.IntervalAutoMode =
                IntervalAutoMode.VariableCount;

            _salesChart.ChartAreas.Add(area);

            _salesChart.Legends.Clear();

            pnlSalesChart.Controls.Add(_salesChart);

            _salesChart.BringToFront();
            lblSalesChartTitle.BringToFront();
        }

        // Methode N°3

        private async Task LoadSalesChartAsync(
            DateTime fromDate,
            DateTime toDate)
        {
            if (_salesChart == null)
                return;

            List<SalesReportItem> sales =
                await _reportService.GetSalesReportAsync(
                    fromDate,
                    toDate
                );

            var dailyRevenue = sales
                .GroupBy(s => s.OrderDate.Date)
                .OrderBy(g => g.Key)
                .Select(g => new
                {
                    Date = g.Key,
                    Revenue = g.Sum(s => s.TotalAmount)
                })
                .ToList();

            _salesChart.Series.Clear();

            ChartArea area = _salesChart.ChartAreas["MainArea"];

            // Reset automatic scaling whenever the report changes
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = double.NaN;
            area.AxisY.Interval = double.NaN;

            if (dailyRevenue.Count == 0)
            {
                area.RecalculateAxesScale();
                _salesChart.Invalidate();
                return;
            }

            Series series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "MainArea",
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                ToolTip = "#VALX: #VALY{N3} DT"
            };

            foreach (var item in dailyRevenue)
            {
                series.Points.AddXY(
                    item.Date.ToString("dd/MM"),
                    Convert.ToDouble(item.Revenue)
                );
            }

            _salesChart.Series.Add(series);

            // Recalculate the axis based on the actual daily revenue values
            area.RecalculateAxesScale();

            _salesChart.Invalidate();
        }

        // Methode N°4
        private async Task GenerateReportAsync()
        {
            if (_isGeneratingReport)
                return;

            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show(
                    "The start date cannot be after the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            _isGeneratingReport = true;

            try
            {
                SalesSummaryReport summary =
                    await _reportService.GetSalesSummaryAsync(
                        fromDate,
                        toDate
                    );

                lblTotalRevenue.Text =
                    $"{summary.TotalRevenue:N3} DT";

                lblTotalOrders.Text =
                    summary.TotalOrders.ToString();

                lblAverageOrderValue.Text =
                    $"{summary.AverageOrderValue:N3} DT";

                lblBestSellingProduct.Text =
                    summary.BestSellingProduct;

                lblBestProductQuantity.Text =
                    $"{summary.BestSellingProductQuantity} units sold";

                await LoadSalesChartAsync(fromDate, toDate);
                await LoadPaymentChartAsync(fromDate, toDate);
                await LoadBestSellingProductsAsync(fromDate, toDate);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    $"Failed to generate report.\n{ex.Message}",
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _isGeneratingReport = false;
            }
        }
        // Methode N°5
        private void InitializePaymentChart()
        {
            _paymentChart = new Chart();

            _paymentChart.Dock = DockStyle.Fill;
            _paymentChart.BackColor = Color.White;
            _paymentChart.BorderlineWidth = 0;

            _paymentChart.ChartAreas.Add("PaymentArea");

            ChartArea area =
                _paymentChart.ChartAreas["PaymentArea"];

            area.BackColor = Color.White;

            // Payment methods legend
            Legend legend = new Legend("PaymentLegend")
            {
                Docking = Docking.Bottom,
                Alignment = StringAlignment.Center
            };

            _paymentChart.Legends.Add(legend);

            pnlPaymentChart.Controls.Add(_paymentChart);

            _paymentChart.BringToFront();
            lblPaymentChartTitle.BringToFront();
        }
        // Methode N°6
        private async Task LoadPaymentChartAsync(DateTime fromDate, DateTime toDate)
        {
            if (_paymentChart == null)
                return;

            // Get orders for the selected period
            List<SalesReportItem> sales =
                await _reportService.GetSalesReportAsync(
                    fromDate,
                    toDate);

            // Group revenue by payment method
            var paymentTotals = sales
                .GroupBy(s =>
                    string.IsNullOrWhiteSpace(s.PaymentMethod)
                        ? "Unknown"
                        : s.PaymentMethod.Trim())
                .Select(g => new
                {
                    PaymentMethod = g.Key,
                    TotalRevenue = g.Sum(s => s.TotalAmount)
                })
                .OrderByDescending(x => x.TotalRevenue)
                .ToList();

            _paymentChart.Series.Clear();

            // No sales in the selected period
            if (paymentTotals.Count == 0)
                return;

            Series series = new Series("Payment Methods")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PaymentArea",
                Legend = "PaymentLegend",
                IsValueShownAsLabel = true,
                Label = "#VALX\n#VALY{N3} DT",
                LegendText = "#VALX",
                Font = new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular)
            };

            foreach (var item in paymentTotals)
            {
                series.Points.AddXY(
                    item.PaymentMethod,
                    Convert.ToDouble(item.TotalRevenue));
            }

            _paymentChart.Series.Add(series);
        }

        // Methode N°7

        private async Task LoadBestSellingProductsAsync(DateTime fromDate, DateTime toDate)
        {
            var products = await _reportService
                .GetBestSellingProductsAsync(fromDate, toDate);

            dgvBestSellingProducts.DataSource = null;
            dgvBestSellingProducts.DataSource = products;

            // Configure column headers
            if (dgvBestSellingProducts.Columns.Count > 0)
            {
                dgvBestSellingProducts.Columns["ProductName"]!
                    .HeaderText = "Product";

                dgvBestSellingProducts.Columns["TotalQuantity"]!
                    .HeaderText = "Quantity Sold";

                dgvBestSellingProducts.Columns["TotalRevenue"]!
                    .HeaderText = "Revenue (DT)";

                // Format revenue to 3 decimal places
                dgvBestSellingProducts.Columns["TotalRevenue"]!
                    .DefaultCellStyle.Format = "N3";

                dgvBestSellingProducts.Columns["TotalQuantity"]!
                    .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                dgvBestSellingProducts.Columns["TotalRevenue"]!
                    .DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
            }
        }

        // Methode N°8

        private async Task ExportReportAsync()
        {
            DateTime fromDate = dtpFromDate.Value.Date;
            DateTime toDate = dtpToDate.Value.Date;

            if (fromDate > toDate)
            {
                MessageBox.Show(
                    "The start date cannot be after the end date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Title = "Export Sales Report",
                Filter = "CSV files (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName =
                    $"SalesReport_{fromDate:yyyyMMdd}_{toDate:yyyyMMdd}.csv"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                // 1. Retrieve report data
                var summary = await _reportService
                    .GetSalesSummaryAsync(fromDate, toDate);

                var sales = await _reportService
                    .GetSalesReportAsync(fromDate, toDate);

                var products = await _reportService
                    .GetBestSellingProductsAsync(fromDate, toDate);

                StringBuilder csv = new StringBuilder();

                // Report information
                csv.AppendLine(CsvRow("COFFEE SYSTEM - SALES REPORT"));
                csv.AppendLine(CsvRow(
                    "From",
                    fromDate.ToString("dd/MM/yyyy",
                        CultureInfo.InvariantCulture)));

                csv.AppendLine(CsvRow(
                    "To",
                    toDate.ToString("dd/MM/yyyy",
                        CultureInfo.InvariantCulture)));

                // 2. Summary
                csv.AppendLine();
                csv.AppendLine(CsvRow("SALES SUMMARY"));
                csv.AppendLine(CsvRow("Metric", "Value"));

                csv.AppendLine(CsvRow(
                    "Total Revenue (DT)",
                    summary.TotalRevenue.ToString(
                        "0.000", CultureInfo.InvariantCulture)));

                csv.AppendLine(CsvRow(
                    "Total Orders",
                    summary.TotalOrders.ToString(
                        CultureInfo.InvariantCulture)));

                csv.AppendLine(CsvRow(
                    "Average Order Value (DT)",
                    summary.AverageOrderValue.ToString(
                        "0.000", CultureInfo.InvariantCulture)));

                csv.AppendLine(CsvRow(
                    "Best-Selling Product",
                    summary.BestSellingProduct));

                csv.AppendLine(CsvRow(
                    "Best-Selling Quantity",
                    summary.BestSellingProductQuantity.ToString(
                        CultureInfo.InvariantCulture)));

                // 3. Daily sales trend
                csv.AppendLine();
                csv.AppendLine(CsvRow("DAILY SALES TREND"));
                csv.AppendLine(CsvRow(
                    "Date", "Orders", "Revenue (DT)"));

                var dailySales = sales
                    .GroupBy(s => s.OrderDate.Date)
                    .OrderBy(g => g.Key);

                foreach (var day in dailySales)
                {
                    csv.AppendLine(CsvRow(
                        day.Key.ToString(
                            "dd/MM/yyyy", CultureInfo.InvariantCulture),
                        day.Count().ToString(
                            CultureInfo.InvariantCulture),
                        day.Sum(s => s.TotalAmount).ToString(
                            "0.000", CultureInfo.InvariantCulture)));
                }

                // 4. Payment methods
                csv.AppendLine();
                csv.AppendLine(CsvRow("PAYMENT METHODS"));
                csv.AppendLine(CsvRow(
                    "Payment Method", "Orders", "Revenue (DT)"));

                var paymentTotals = sales
                    .GroupBy(s =>
                        string.IsNullOrWhiteSpace(s.PaymentMethod)
                            ? "Unknown"
                            : s.PaymentMethod.Trim())
                    .OrderByDescending(g =>
                        g.Sum(s => s.TotalAmount));

                foreach (var payment in paymentTotals)
                {
                    csv.AppendLine(CsvRow(
                        payment.Key,
                        payment.Count().ToString(
                            CultureInfo.InvariantCulture),
                        payment.Sum(s => s.TotalAmount).ToString(
                            "0.000", CultureInfo.InvariantCulture)));
                }

                // 5. Best-selling products
                csv.AppendLine();
                csv.AppendLine(CsvRow("BEST-SELLING PRODUCTS"));
                csv.AppendLine(CsvRow(
                    "Product", "Quantity Sold", "Revenue (DT)"));

                foreach (var product in products)
                {
                    csv.AppendLine(CsvRow(
                        product.ProductName,
                        product.TotalQuantity.ToString(
                            CultureInfo.InvariantCulture),
                        product.TotalRevenue.ToString(
                            "0.000", CultureInfo.InvariantCulture)));
                }

                // UTF-8 BOM helps Excel display Arabic and accented text.
                File.WriteAllText(
                    dialog.FileName,
                    csv.ToString(),
                    new UTF8Encoding(true));

                MessageBox.Show(
                    "Report exported successfully!",
                    "Export Complete",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to export report.\n{ex.Message}",
                    "Export Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string CsvRow(params string[] values)
        {
            return string.Join(";",
                values.Select(value =>
                    "\"" +
                    (value ?? string.Empty).Replace("\"", "\"\"") +
                    "\""));
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void frmReports_Load(object sender, EventArgs e)
        {

        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            await GenerateReportAsync();


        }

        private async void btnGenerateReport_Click_1(object sender, EventArgs e)
        {
            await GenerateReportAsync();

        }

        private void cmbPeriod_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;

            _isUpdatingPeriodDates = true;

            try
            {
                switch (cmbPeriod.SelectedItem?.ToString())
                {
                    case "Today":
                        dtpFromDate.Value = today;
                        dtpToDate.Value = today;
                        break;

                    case "This Week":
                        int diff = ((int)today.DayOfWeek + 6) % 7;
                        DateTime monday = today.AddDays(-diff);

                        dtpFromDate.Value = monday;
                        dtpToDate.Value = today;
                        break;

                    case "This Month":
                        dtpFromDate.Value = new DateTime(
                            today.Year, today.Month, 1);

                        dtpToDate.Value = today;
                        break;

                    case "Custom Range":
                        // نخليوا المستخدم يختار التواريخ بيدو
                        break;
                }
            }
            finally
            {
                _isUpdatingPeriodDates = false;
            }


        }


        private async void btnResetFilters_Click(object sender, EventArgs e)
        { // Reset period
            cmbPeriod.SelectedIndex = 0;

            // Reset dates
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today;

            // Refresh the report
            await GenerateReportAsync();

        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdatingPeriodDates)
                return;

            if (cmbPeriod.SelectedItem?.ToString() != "Custom Range")
            {
                cmbPeriod.SelectedItem = "Custom Range";
            }
        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdatingPeriodDates)
                return;

            if (cmbPeriod.SelectedItem?.ToString() != "Custom Range")
            {
                cmbPeriod.SelectedItem = "Custom Range";
            }
        }

        private async void frmReports_Shown(object sender, EventArgs e)
        {
            await GenerateReportAsync();


        }



        private async void btnExportReport_Click(object sender, EventArgs e)
        {
            await ExportReportAsync();


        }

        private void dgvBestSellingProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

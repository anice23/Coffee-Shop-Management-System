using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmOrderDetails : Form
    {
        private readonly PrintDocument _printDocument;
        private readonly Order _order;
        private readonly AppDbContext _context;
        private readonly CafeSettingsService _settingsService;
        private string _receiptFooter = string.Empty;
        private string _cafeName = "COFFEE SYSTEM";
        private string _cafeAddress = string.Empty;
        private string _cafePhoneNumber = string.Empty;
        public frmOrderDetails(Order order)
        {
            InitializeComponent();

            _order = order;
            _printDocument = new PrintDocument();

            _context = CreateDbContext();
            _settingsService = CreateSettingsService();

            ConfigurePrinting();
            ConfigurePaperSize();
            ConfigureDataGrid();
            LoadOrderInfo(order);
            LoadItems(order);
        }
        private AppDbContext CreateDbContext()
        {
            return new AppDbContext();
        }
        private CafeSettingsService CreateSettingsService()
        {
            CafeSettingsRepository repository =
                new CafeSettingsRepository(_context);

            return new CafeSettingsService(repository);
        }

        // Methode : Config print document
        private void ConfigurePrinting()
        {

            ConfigurePaperSize();

            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        // Methode N°1
        private void ConfigureDataGrid()
        {
            dgvItems.AutoGenerateColumns = false;

            dgvItems.AllowUserToAddRows = false;
            dgvItems.ReadOnly = true;

            dgvItems.RowHeadersVisible = false;

            dgvItems.MultiSelect = false;
            dgvItems.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;

            dgvItems.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            dgvItems.GridColor = Color.LightGray;

            dgvItems.ColumnHeadersHeight = 40;

            dgvItems.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvItems.ColumnHeadersDefaultCellStyle.BackColor =
                Color.White;

            dgvItems.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(60, 60, 60);

            dgvItems.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvItems.DefaultCellStyle.BackColor =
                Color.White;

            dgvItems.DefaultCellStyle.ForeColor =
                Color.FromArgb(60, 60, 60);

            dgvItems.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(239, 235, 233);

            dgvItems.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(60, 60, 60);

            dgvItems.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Methode N°2 : Load Order info
        private void LoadOrderInfo(Order order)
        {
            lblOrderId.Text =
                $"Order ID: {order.OrderId}";

            lblOrderDate.Text =
                $"Date: {order.OrderDate:dd/MM/yyyy HH:mm}";

            lblPayment.Text =
                $"Payment: {order.PaymentMethod}";

            lblCashier.Text =
                $"Cashier: {order.User.FullName}";
            lblTotal.Text = $"Total:{order.TotalAmount:0.000} DT";
        }

        // Methode N°3 : Load Order Items Products
        private void LoadItems(Order order)
        {
            dgvItems.Rows.Clear();

            foreach (OrderItem item in order.OrderItems)
            {
                dgvItems.Rows.Add(
                    item.Product.Name,
                    item.Quantity,
                    $"{item.UnitPrice:0.000} DT",
                    $"{item.TotalPrice:0.000} DT"
                );
            }
        }

        // Methode N°4 : Print Document
        private void PrintDocument_PrintPage(object? sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            // =========================
            // Fonts
            // =========================

            using Font titleFont =
                new Font("Segoe UI", 16, FontStyle.Bold);

            using Font infoFont =
                new Font("Segoe UI", 9, FontStyle.Regular);

            using Font headerFont =
                new Font("Segoe UI", 9, FontStyle.Bold);

            using Font itemFont =
                new Font("Segoe UI", 9, FontStyle.Regular);


            // =========================
            // String Formats
            // =========================

            using StringFormat centerFormat =
                new StringFormat
                {
                    Alignment = StringAlignment.Center
                };

            using StringFormat leftFormat =
                new StringFormat
                {
                    Alignment = StringAlignment.Near
                };

            using StringFormat rightFormat =
                new StringFormat
                {
                    Alignment = StringAlignment.Far
                };


            // =========================
            // Page Width
            // =========================

            float pageWidth =
                e.PageBounds.Width;


            // =========================
            // Title
            // =========================

            g.DrawString(
                _cafeName,
                titleFont,
                Brushes.Black,
                new RectangleF(
                    0,
                    30,
                    pageWidth,
                    30
                ),
                centerFormat
            );

            // + Phone Number & Address

            float headerInfoY = 62;

            // Cafe Address
            if (!string.IsNullOrWhiteSpace(_cafeAddress))
            {
                g.DrawString(
                    _cafeAddress,
                    infoFont,
                    Brushes.Black,
                    new RectangleF(
                        20,
                        headerInfoY,
                        pageWidth - 40,
                        20
                    ),
                    centerFormat
                );

                headerInfoY += 20;
            }

            // Cafe Phone Number
            if (!string.IsNullOrWhiteSpace(_cafePhoneNumber))
            {
                g.DrawString(
                    $"Tel: {_cafePhoneNumber}",
                    infoFont,
                    Brushes.Black,
                    new RectangleF(
                        20,
                        headerInfoY,
                        pageWidth - 40,
                        20
                    ),
                    centerFormat
                );

                headerInfoY += 20;
            }

            // =========================
            // Order Information
            // =========================

            float infoY = Math.Max(75, headerInfoY + 5);
            g.DrawString(
                $"Order ID: {_order.OrderId}",
                infoFont,
                Brushes.Black,
                20,
                infoY
            );

            infoY += 20;

            g.DrawString(
                $"Date: {_order.OrderDate:dd/MM/yyyy HH:mm}",
                infoFont,
                Brushes.Black,
                20,
                infoY
            );

            infoY += 20;

            g.DrawString(
                $"Payment: {_order.PaymentMethod}",
                infoFont,
                Brushes.Black,
                20,
                infoY
            );

            infoY += 20;

            g.DrawString(
                $"Cashier: {_order.User.FullName}",
                infoFont,
                Brushes.Black,
                20,
                infoY
            );


            // =========================
            // Separator
            // =========================

            infoY += 25;

            g.DrawLine(
                Pens.Black,
                20,
                infoY,
                pageWidth - 20,
                infoY
            );


            // =========================
            // Products Table
            // =========================

            int y = (int)infoY + 15;


            // Column positions

            float productX = 20;
            float quantityX = 205;
            float totalX = 250;


            // =========================
            // Table Header
            // =========================

            g.DrawString(
                "Product",
                headerFont,
                Brushes.Black,
                new RectangleF(
                    productX,
                    y,
                    175,
                    25
                ),
                leftFormat
            );

            g.DrawString(
                "Qty",
                headerFont,
                Brushes.Black,
                new RectangleF(
                    quantityX,
                    y,
                    40,
                    25
                ),
                centerFormat
            );

            g.DrawString(
                "Total",
                headerFont,
                Brushes.Black,
                new RectangleF(
                    totalX,
                    y,
                    45,
                    25
                ),
                rightFormat
            );


            y += 25;


            // =========================
            // Separator
            // =========================

            g.DrawLine(
                Pens.Black,
                20,
                y,
                pageWidth - 20,
                y
            );


            y += 10;


            // =========================
            // Products
            // =========================

            foreach (OrderItem item in _order.OrderItems)
            {
                decimal itemTotal =
                    item.Quantity * item.UnitPrice;


                // Product Name

                g.DrawString(
                    item.Product.Name,
                    itemFont,
                    Brushes.Black,
                    new RectangleF(
                        productX,
                        y,
                        175,
                        30
                    ),
                    leftFormat
                );


                // Quantity

                g.DrawString(
                    item.Quantity.ToString(),
                    itemFont,
                    Brushes.Black,
                    new RectangleF(
                        quantityX,
                        y,
                        40,
                        30
                    ),
                    centerFormat
                );


                // Total

                g.DrawString(
                    $"{itemTotal:0.000}",
                    itemFont,
                    Brushes.Black,
                    new RectangleF(
                        totalX,
                        y,
                        45,
                        30
                    ),
                    rightFormat
                );


                y += 30;
            }
            y += 10;

            // Separator
            g.DrawLine(
                Pens.Black,
                20,
                y,
                pageWidth - 20,
                y
            );

            y += 15;

            // Total
            using Font totalFont =
                new Font("Segoe UI", 11, FontStyle.Bold);

            g.DrawString(
                $"TOTAL: {_order.TotalAmount:0.000} DT",
                totalFont,
                Brushes.Black,
                new RectangleF(
                    150,
                    y,
                    145,
                    30
                ),
                rightFormat
            );
            // Receipt Footer
            if (!string.IsNullOrWhiteSpace(_receiptFooter))
            {
                y += 40;

                g.DrawString(
                    _receiptFooter,
                    infoFont,
                    Brushes.Black,
                    new RectangleF(
                        20,
                        y,
                        pageWidth - 40,
                        50
                    ),
                    centerFormat
                );
            }
        }

        // Methode N°5 : Configu print document dimensions

        private void ConfigurePaperSize()
        {
            int baseHeight = 350;

            // Extra space for cafe information
            if (!string.IsNullOrWhiteSpace(_cafeAddress))
                baseHeight += 20;

            if (!string.IsNullOrWhiteSpace(_cafePhoneNumber))
                baseHeight += 20;

            // Extra space for receipt footer
            if (!string.IsNullOrWhiteSpace(_receiptFooter))
                baseHeight += 30;

            int itemHeight = 30;

            int totalHeight =
                baseHeight +
                (_order.OrderItems.Count * itemHeight);

            _printDocument.DefaultPageSettings.PaperSize =
                new PaperSize(
                    "Receipt",
                    315,
                    totalHeight
                );
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                btnPrint.Enabled = false;

                // Load current cafe settings from SQL Server
                var settings = await _settingsService.GetSettingsAsync();

                _receiptFooter = settings?.ReceiptFooter ?? string.Empty;
                _cafeName = string.IsNullOrWhiteSpace(settings?.CafeName) ? "COFFEE SYSTEM" : settings.CafeName;

                _cafeAddress = settings?.Address ?? string.Empty;
                _cafePhoneNumber = settings?.PhoneNumber ?? string.Empty;

                _receiptFooter = settings?.ReceiptFooter ?? string.Empty;
                // Configure receipt size before showing preview
                ConfigurePaperSize();

                using PrintPreviewDialog preview = new PrintPreviewDialog();

                preview.Document = _printDocument;

                preview.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to prepare receipt.\n{ex.Message}",
                    "Printing Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnPrint.Enabled = true;
            }
        }
    }
}

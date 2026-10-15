
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmReceipt : Form
    {
        private readonly Order _order;
        private readonly AppDbContext _context;
        private readonly ProductService _productService;
        private readonly CafeSettingsService _settingsService;

        private string _cashierName = "Unknown";

        private readonly PrintDocument _printDocument =
            new PrintDocument();

        private string _cafeName = "COFFEE SHOP";
        private string _cafeAddress = string.Empty;
        private string _cafePhoneNumber = string.Empty;
        private string _receiptFooter = string.Empty;

        // Keep receipt products in memory before printing
        private List<Product> _receiptProducts =
            new List<Product>();

        private bool _isReceiptDataLoaded;
        private bool _isPrinting;

        public frmReceipt(Order order)
        {
            InitializeComponent();

            _order = order;

            _context = CreateDbContext();
            _productService = CreateProductService();
            _settingsService = CreateSettingsService();

            lblOrderId.Text = $"Order #: {_order.OrderId}";
            lblOrderDate.Text =
                $"Date: {_order.OrderDate:dd/MM/yyyy HH:mm}";

            lblPaymentMethod.Text =
                $"Payment Method: {_order.PaymentMethod}";

            lblCashier.Text = "Cashier: Loading...";
            lblReceiptTotal.Text =
                $"{_order.TotalAmount:0.000} DT";

            // Load receipt data asynchronously when the form appears
            btnPrint.Enabled = false;
            Shown += frmReceipt_Shown;

            _printDocument.PrintPage += PrintDocument_PrintPage;
        }

        // Create DbContext
        private AppDbContext CreateDbContext()
        {
            return new AppDbContext();
        }

        // Create ProductService
        private ProductService CreateProductService()
        {
            ProductRepository repository =
                new ProductRepository(_context);

            return new ProductService(repository);
        }

        // Create CafeSettingsService
        private CafeSettingsService CreateSettingsService()
        {
            CafeSettingsRepository repository =
                new CafeSettingsRepository(_context);

            return new CafeSettingsService(repository);
        }

        // Load receipt data
        private async void frmReceipt_Shown(
            object sender,
            EventArgs e)
        {
            try
            {
                await LoadReceiptDataAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل بيانات الفاتورة. حاول مجددًا.",
                    "Receipt Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnPrint.Enabled = true;
                }
            }
        }

        // Load receipt data asynchronously
        private async Task LoadReceiptDataAsync()
        {
            // Get the user associated with this order
            var orderUser = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(
                    u => u.UserId == _order.UserId
                );

            _cashierName = orderUser == null
                ? "Unknown"
                : (!string.IsNullOrWhiteSpace(orderUser.FullName)
                    ? orderUser.FullName
                    : orderUser.UserName);

            lblCashier.Text = $"Cashier: {_cashierName}";

            // Load products asynchronously before printing
            _receiptProducts =
                await _productService.GettAllProductsAsync();

            // Display receipt items using cached products
            LoadReceiptItems();

            _isReceiptDataLoaded = true;
        }

        // Load data in receipt
        private void LoadReceiptItems()
        {
            dgvReceiptItems.Rows.Clear();

            foreach (var item in _order.OrderItems)
            {
                var product = _receiptProducts.FirstOrDefault(
                    p => p.ProductId == item.ProductId
                );

                if (product == null)
                    continue;

                dgvReceiptItems.Rows.Add(
                    product.Name,
                    item.Quantity,
                    $"{item.UnitPrice:0.000} DT",
                    $"{item.TotalPrice:0.000} DT"
                );
            }
        }

        // Method mta3 printing
        private void PrintDocument_PrintPage(
            object sender,
            PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using Font titleFont =
                new Font("Arial", 16, FontStyle.Bold);

            using Font normalFont =
                new Font("Arial", 10);

            using Font boldFont =
                new Font("Arial", 10, FontStyle.Bold);

            float x = 40;
            float y = 40;

            using StringFormat centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Shop name - Centered
            g.DrawString(
                _cafeName,
                titleFont,
                Brushes.Black,
                new RectangleF(x, y, 265, 30),
                centerFormat
            );

            y += 30;

            // Cafe address
            if (!string.IsNullOrWhiteSpace(_cafeAddress))
            {
                g.DrawString(
                    _cafeAddress,
                    normalFont,
                    Brushes.Black,
                    new RectangleF(x, y, 265, 25),
                    centerFormat
                );

                y += 25;
            }

            // Cafe phone number
            if (!string.IsNullOrWhiteSpace(_cafePhoneNumber))
            {
                g.DrawString(
                    $"Tel: {_cafePhoneNumber}",
                    normalFont,
                    Brushes.Black,
                    new RectangleF(x, y, 265, 25),
                    centerFormat
                );

                y += 25;
            }

            // Receipt title
            g.DrawString(
                "RECEIPT",
                boldFont,
                Brushes.Black,
                x,
                y
            );

            y += 30;

            // Order information
            g.DrawString(
                $"Order #: {_order.OrderId}",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 20;

            g.DrawString(
                $"Date: {_order.OrderDate:dd/MM/yyyy HH:mm}",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 20;

            g.DrawString(
                $"Payment: {_order.PaymentMethod}",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 20;

            g.DrawString(
                $"Cashier: {_cashierName}",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 30;

            // Separator
            g.DrawString(
                "--------------------------------",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 25;

            // Products - use already loaded data
            g.DrawString(
                "PRODUCT",
                boldFont,
                Brushes.Black,
                x,
                y
            );

            g.DrawString(
                "QTY",
                boldFont,
                Brushes.Black,
                x + 180,
                y
            );

            g.DrawString(
                "TOTAL",
                boldFont,
                Brushes.Black,
                x + 230,
                y
            );

            y += 25;

            foreach (var item in _order.OrderItems)
            {
                var product = _receiptProducts.FirstOrDefault(
                    p => p.ProductId == item.ProductId
                );

                if (product == null)
                    continue;

                g.DrawString(
                    product.Name,
                    normalFont,
                    Brushes.Black,
                    x,
                    y
                );

                g.DrawString(
                    item.Quantity.ToString(),
                    normalFont,
                    Brushes.Black,
                    x + 180,
                    y
                );

                g.DrawString(
                    item.TotalPrice.ToString("0.000"),
                    normalFont,
                    Brushes.Black,
                    x + 230,
                    y
                );

                y += 25;
            }

            // Separator
            g.DrawString(
                "--------------------------------",
                normalFont,
                Brushes.Black,
                x,
                y
            );

            y += 30;

            // Total
            g.DrawString(
                $"TOTAL: {_order.TotalAmount:0.000} DT",
                boldFont,
                Brushes.Black,
                x,
                y
            );

            y += 35;

            if (!string.IsNullOrWhiteSpace(_receiptFooter))
            {
                using StringFormat footerFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near
                };

                g.DrawString(
                    _receiptFooter,
                    normalFont,
                    Brushes.Black,
                    new RectangleF(20, y, 305, 50),
                    footerFormat
                );
            }
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
        }

        private async void btnPrint_Click(
            object sender,
            EventArgs e)
        {
            // Prevent duplicate print operations
            if (_isPrinting)
                return;

            _isPrinting = true;
            btnPrint.Enabled = false;

            try
            {
                // Retry loading receipt data if initial loading failed
                if (!_isReceiptDataLoaded)
                {
                    await LoadReceiptDataAsync();
                }

                // Load cafe settings asynchronously
                var settings =
                    await _settingsService.GetSettingsAsync();

                _cafeName =
                    string.IsNullOrWhiteSpace(settings?.CafeName)
                        ? "COFFEE SHOP"
                        : settings.CafeName;

                _cafeAddress = settings?.Address ?? string.Empty;
                _cafePhoneNumber =
                    settings?.PhoneNumber ?? string.Empty;

                _receiptFooter =
                    settings?.ReceiptFooter ?? string.Empty;

                int receiptHeight =
                    340 + (_order.OrderItems.Count * 45);

                if (!string.IsNullOrWhiteSpace(_cafeAddress))
                    receiptHeight += 20;

                if (!string.IsNullOrWhiteSpace(_cafePhoneNumber))
                    receiptHeight += 20;

                if (!string.IsNullOrWhiteSpace(_receiptFooter))
                    receiptHeight += 30;

                _printDocument.DefaultPageSettings.PaperSize =
                    new PaperSize(
                        "Receipt 80mm",
                        345,
                        receiptHeight
                    );

                using (PrintPreviewDialog preview =
                    new PrintPreviewDialog())
                {
                    preview.Document = _printDocument;
                    preview.Width = 800;
                    preview.Height = 600;

                    preview.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّرت طباعة الفاتورة. حاول مجددًا.",
                    "Receipt Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _isPrinting = false;

                if (!IsDisposed)
                {
                    btnPrint.Enabled = true;
                }
            }
        }
    }
}

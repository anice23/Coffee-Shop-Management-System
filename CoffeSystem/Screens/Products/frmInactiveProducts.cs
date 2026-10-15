
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmInactiveProducts : Form
    {
        private readonly ProductService _productService;
        private bool _isProcessingRestore;

        public frmInactiveProducts()
        {
            InitializeComponent();

            _productService = CreateProductService();

            ConfigureDataGrid();

            // Products are loaded asynchronously in the Load event.
        }

        private async void frmInactiveProducts_Load(
            object sender,
            EventArgs e)
        {
            try
            {
                await LoadInactiveProductsAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل المنتجات المعطّلة. حاول مجددًا.",
                    "Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Config datagrid
        public void ConfigureDataGrid()
        {
            DataGridViewButtonColumn restoreColumn =
                (DataGridViewButtonColumn)dgvInactiveProducts
                    .Columns["colRestore"];

            restoreColumn.Text = "Restore";
            restoreColumn.UseColumnTextForButtonValue = true;
        }

        // Methode N°1 create ProductService
        private ProductService CreateProductService()
        {
            AppDbContext context = new AppDbContext();

            ProductRepository repository =
                new ProductRepository(context);

            return new ProductService(repository);
        }

        // Methode N°2 Load Inactive Products
        private async Task LoadInactiveProductsAsync()
        {
            List<Product> products =
                await _productService.GetInactiveProductsAsync();

            dgvInactiveProducts.Rows.Clear();

            foreach (Product product in products)
            {
                dgvInactiveProducts.Rows.Add(
                    product.ProductId,
                    product.Name,
                    LoadProductImage(product.ImagePath),
                    $"{product.Price:0.000} DT",
                    product.StockQuantity,
                    product.Category?.Name ?? "No Category"
                );
            }
        }

        // Methode N°3 Load Product Image
        private Image? LoadProductImage(string? imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return null;

            string fullPath = Path.Combine(
                Directory.GetParent(
                    Application.StartupPath
                )!.Parent!.Parent!.Parent!.FullName,
                imagePath
            );

            if (!File.Exists(fullPath))
                return null;

            using (FileStream stream = new FileStream(
                fullPath,
                FileMode.Open,
                FileAccess.Read))
            {
                using (Image tempImage = Image.FromStream(stream))
                {
                    return new Bitmap(tempImage);
                }
            }
        }

        private async void dgvInactiveProducts_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvInactiveProducts.Columns[e.ColumnIndex].Name
                != "colRestore")
            {
                return;
            }

            // Prevent duplicate restore operations
            if (_isProcessingRestore)
                return;

            int productId = Convert.ToInt32(
                dgvInactiveProducts.Rows[e.RowIndex]
                    .Cells["colProductId"]
                    .Value
            );

            DialogResult result = MessageBox.Show(
                "Do you want to restore this product?",
                "Restore Product",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result != DialogResult.Yes)
                return;

            _isProcessingRestore = true;
            dgvInactiveProducts.Enabled = false;

            try
            {
                await _productService.ActivateProductAsync(productId);

                MessageBox.Show(
                    "Product restored successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                await LoadInactiveProductsAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _isProcessingRestore = false;

                if (!IsDisposed)
                {
                    dgvInactiveProducts.Enabled = true;
                }
            }
        }
    }
}

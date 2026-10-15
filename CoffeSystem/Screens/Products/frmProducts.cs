
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmProducts : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;

        private List<Product> _allProducts = new List<Product>();

        private bool _isClearingFilters;

        public frmProducts()
        {
            InitializeComponent();

            _productService = CreateProductService();
            _categoryService = CreateCategoryService();

            ConfigureDataGrid();

            // Bind this event only once.
      

            // Load categories and products asynchronously.
            // Remove a duplicate Shown binding from the Designer if present.
            Shown += frmProducts_Shown;
        }

        // Create Product Service
        private ProductService CreateProductService()
        {
            AppDbContext context = new AppDbContext();

            ProductRepository repository =
                new ProductRepository(context);

            return new ProductService(repository);
        }

        // Create Category Service
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // Form Shown Event
        private async void frmProducts_Shown(
            object sender,
            EventArgs e)
        {
            try
            {
                // Load categories before products.
                await LoadCategoriesAsync();

                await LoadProductsSafelyAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل الأصناف. حاول مجددًا.",
                    "Categories Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Method 1: Configure DataGridView
        private void ConfigureDataGrid()
        {
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AllowUserToAddRows = false;

            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            dgvProducts.ColumnHeadersHeight = 40;

            // Edit button
            DataGridViewButtonColumn editColumn =
                new DataGridViewButtonColumn();

            editColumn.Name = "colEdit";
            editColumn.HeaderText = "Edit";
            editColumn.Text = "Edit";
            editColumn.UseColumnTextForButtonValue = true;
            editColumn.Width = 80;
            editColumn.ReadOnly = true;

            editColumn.DefaultCellStyle.BackColor =
                Color.FromArgb(109, 76, 65);

            editColumn.DefaultCellStyle.ForeColor =
                Color.White;

            editColumn.DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            editColumn.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.Add(editColumn);

            // Delete button - soft delete
            DataGridViewButtonColumn deleteColumn =
                new DataGridViewButtonColumn();

            deleteColumn.Name = "colDelete";
            deleteColumn.HeaderText = "Delete";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;

            deleteColumn.DefaultCellStyle.BackColor =
                Color.FromArgb(198, 40, 40);

            deleteColumn.DefaultCellStyle.ForeColor =
                Color.White;

            deleteColumn.DefaultCellStyle.Font =
                new Font("Segoe UI", 9, FontStyle.Bold);

            deleteColumn.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.Columns.Add(deleteColumn);
        }

        // Method 2: Load Active Products Asynchronously
        private async Task LoadProductsAsync()
        {
            lblNoProducts.Visible = false;

            _allProducts =
                await _productService.GettAllProductsAsync();

            // Apply the current search and category filters.
            ApplyFilters();
        }

        // Safely refresh products
        private async Task LoadProductsSafelyAsync()
        {
            try
            {
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل المنتجات. حاول مجددًا.",
                    "Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Method 3: Load Categories Asynchronously
        private async Task LoadCategoriesAsync()
        {
            List<Category> categories =
                await _categoryService.GetAllCategoriesAsync();

            _isClearingFilters = true;

            try
            {
                cmbCategory.Items.Clear();

                cmbCategory.Items.Add(
                    new Category
                    {
                        CategoryId = 0,
                        Name = "All Categories"
                    }
                );

                foreach (Category category in categories)
                {
                    cmbCategory.Items.Add(category);
                }

                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";

                cmbCategory.SelectedIndex = 0;
            }
            finally
            {
                _isClearingFilters = false;
            }
        }

        // Method 4: Load Product Image Without Locking File
        private Image? LoadProductImage(string? imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
                return null;

            string projectFolder =
                Directory.GetParent(
                    Application.StartupPath
                )!.Parent!.Parent!.Parent!.FullName;

            string fullPath = Path.Combine(
                projectFolder,
                imagePath
            );

            if (!File.Exists(fullPath))
                return null;

            try
            {
                using (FileStream stream = new FileStream(
                    fullPath,
                    FileMode.Open,
                    FileAccess.Read,
                    FileShare.ReadWrite))
                {
                    using (Image tempImage = Image.FromStream(stream))
                    {
                        // Return an independent image without locking the file.
                        return new Bitmap(tempImage);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                return null;
            }
        }

        // Release images before clearing the grid
        private void ClearProductGridImages()
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value is Image image)
                    {
                        cell.Value = null;
                        image.Dispose();
                    }
                }
            }
        }

        // Method 5: Search and Filter Products In Memory
        private void ApplyFilters()
        {
            string searchText =
                txtSearchProduct.Text.Trim();

            int? categoryId = null;

            if (cmbCategory.SelectedItem is Category selectedCategory &&
                selectedCategory.CategoryId > 0)
            {
                categoryId = selectedCategory.CategoryId;
            }

            List<Product> products = _allProducts
                .Where(product =>
                    (
                        string.IsNullOrWhiteSpace(searchText) ||
                        product.Name.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                    &&
                    (
                        !categoryId.HasValue ||
                        product.CategoryId == categoryId.Value
                    )
                )
                .OrderBy(product => product.Name)
                .ToList();

            // Dispose previous row images before rebuilding the grid.
            ClearProductGridImages();

            dgvProducts.Rows.Clear();

            foreach (Product product in products)
            {
                dgvProducts.Rows.Add(
                    product.ProductId,
                    product.Name,
                    LoadProductImage(product.ImagePath),
                    $"{product.Price:0.000} DT",
                    product.StockQuantity,
                    product.Category?.Name ?? "No Category"
                );
            }

            lblNoProducts.Visible = products.Count == 0;
        }

        private void frmProducts_Load(
            object sender,
            EventArgs e)
        {
            // Product loading is handled by frmProducts_Shown.
        }

        private void pnlProductsHeader_Paint(
            object sender,
            PaintEventArgs e)
        {
            // Existing designer event.
        }

        // Method 6: Edit and Deactivate Products
        private async void dgvProducts_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string columnName =
                dgvProducts.Columns[e.ColumnIndex].Name;

            if (columnName != "colEdit" &&
                columnName != "colDelete")
            {
                return;
            }

            int productId = Convert.ToInt32(
                dgvProducts.Rows[e.RowIndex]
                    .Cells["colProductId"].Value
            );

            // Edit Product
            if (columnName == "colEdit")
            {
                try
                {
                    Product? product =
                        await _productService.GetProductByIdAsync(
                            productId
                        );

                    if (product == null)
                    {
                        MessageBox.Show(
                            "Product not found.",
                            "Warning",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );

                        await LoadProductsSafelyAsync();
                        return;
                    }

                    using (frmEditProduct editForm =
                        new frmEditProduct(product))
                    {
                        DialogResult result =
                            editForm.ShowDialog(this);

                        if (result == DialogResult.OK)
                        {
                            await LoadProductsSafelyAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());

                    MessageBox.Show(
                        "An error occurred while opening the product.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                return;
            }

            // Delete Product - Soft Delete
            DialogResult deleteResult = MessageBox.Show(
                "Are you sure you want to deactivate this product?",
                "Confirm Deactivation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );

            if (deleteResult != DialogResult.Yes)
                return;

            dgvProducts.Enabled = false;

            try
            {
                await _productService.DeactivateProductAsync(
                    productId
                );

                MessageBox.Show(
                    "Product deactivated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                await LoadProductsSafelyAsync();
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
                if (!IsDisposed)
                {
                    dgvProducts.Enabled = true;
                }
            }
        }

        // Method 7: Add Product
        private async void btnAddProduct_Click(
            object sender,
            EventArgs e)
        {
            using (frmAddProduct addForm =
                new frmAddProduct())
            {
                DialogResult result =
                    addForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    await LoadProductsSafelyAsync();
                }
            }
        }

        // Method 8: View Inactive Products
        private async void btnInactiveProducts_Click(
            object sender,
            EventArgs e)
        {
            using (frmInactiveProducts form =
                new frmInactiveProducts())
            {
                form.ShowDialog(this);
            }

            await LoadProductsSafelyAsync();
        }

        // Method 9: Live Search
        private void txtSearchProduct_TextChanged(
            object sender,
            EventArgs e)
        {
            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        // Method 10: Category Filter
        private void cmbCategory_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (_isClearingFilters)
                return;

            ApplyFilters();
        }

        // Method 11: Clear Filters
        private void btnClearFilters_Click(
            object sender,
            EventArgs e)
        {
            _isClearingFilters = true;

            try
            {
                txtSearchProduct.Clear();

                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0;
                }
            }
            finally
            {
                _isClearingFilters = false;
            }

            ApplyFilters();
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            // Release image resources held by the DataGridView.
            ClearProductGridImages();

            base.OnFormClosed(e);
        }
    }
}

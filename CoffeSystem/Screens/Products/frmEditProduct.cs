
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmEditProduct : Form
    {
        private readonly Product _product;
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private readonly ProductImageService _productImageService;

        private string? _imagePath;
        private string? _newImagePath;

        public frmEditProduct(Product product)
        {
            InitializeComponent();

            _product = product;

            _productService = CreateProductService();
            _categoryService = CreateCategories();
            _productImageService = CreateProductImageService();

            Shown += frmEditProduct_Shown;
        }

        // 
        private async void frmEditProduct_Shown(object sender,EventArgs e)
        {
            btnUpdate.Enabled = false;

            bool categoriesLoaded = false;

            try
            {
                await LoadCategoriesAsync();

                // Load product data after categories are ready
                LoadProductData();

                categoriesLoaded = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "Unable to load product data. Please try again.",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnUpdate.Enabled = categoriesLoaded;
                }
            }
        }
        // Methode N°1 : LoadData
        private void LoadProductData()
        {
            txtProductName.Text = _product.Name;
            nudPrice.Value = _product.Price;
            nudStock.Value = _product.StockQuantity;

            cmbCategory.SelectedValue = _product.CategoryId;

            if (!string.IsNullOrWhiteSpace(_product.ImagePath))
            {
                string fullPath = Path.Combine(
                    Directory.GetParent(
                        Application.StartupPath
                    )!.Parent!.Parent!.Parent!.FullName,
                    _product.ImagePath
                );

                if (File.Exists(fullPath))
                {
                    ClearProductImage();

                    picProduct.Image =
                        LoadImageWithoutLock(fullPath);
                }
            }
        }

        // Methode N°2 : Update Data
        private void UpdateProductData()
        {
            _product.Name = txtProductName.Text;
            _product.Price = nudPrice.Value;
            _product.StockQuantity = (int)nudStock.Value;

            _product.CategoryId = Convert.ToInt32(
                cmbCategory.SelectedValue
            );

            if (_imagePath != null)
            {
                _product.ImagePath = _imagePath;
            }
        }

        // Methode N°3
        private ProductService CreateProductService()
        {
            AppDbContext context = new AppDbContext();

            ProductRepository repository =
                new ProductRepository(context);

            return new ProductService(repository);
        }

        // Methode N°4
        private CategoryService CreateCategories()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // Methode N°5
        // Methode N°5
        private async Task LoadCategoriesAsync()
        {
            var categories =
                await _categoryService.GetAllCategoriesAsync();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
        }

        // Methode N°6 : edit Image
        private ProductImageService CreateProductImageService()
        {
            string imagesFolder = Path.Combine(
                Directory.GetParent(
                    Application.StartupPath
                )!.Parent!.Parent!.Parent!.FullName,
                "Images",
                "Products"
            );

            return new ProductImageService(imagesFolder);
        }

        // Methode N°7
        private Image? LoadImageWithoutLock(string imagePath)
        {
            if (!File.Exists(imagePath))
                return null;

            using (FileStream stream = new FileStream(
                imagePath,
                FileMode.Open,
                FileAccess.Read))
            {
                using (Image tempImage = Image.FromStream(stream))
                {
                    return new Bitmap(tempImage);
                }
            }
        }

        // Methodne N°8
        private void DeleteOldImage(string imagePath)
        {
            string fullPath = Path.Combine(
                Directory.GetParent(
                    Application.StartupPath
                )!.Parent!.Parent!.Parent!.FullName,
                imagePath
            );

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }
        }

        // Methode N°9
        private void ClearProductImage()
        {
            if (picProduct.Image != null)
            {
                Image oldImage = picProduct.Image;

                picProduct.Image = null;

                oldImage.Dispose();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                string fileName =
                    _productImageService.SaveImage(dialog.FileName);

                _imagePath = Path.Combine(
                    "Images",
                    "Products",
                    fileName
                );

                _newImagePath = _imagePath;

                string fullPath = Path.Combine(
                    Directory.GetParent(
                        Application.StartupPath
                    )!.Parent!.Parent!.Parent!.FullName,
                    _imagePath
                );

                ClearProductImage();

                picProduct.Image =
                    LoadImageWithoutLock(fullPath);
            }
        }

        private void frmEditProduct_Load(object sender, EventArgs e)
        {
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            // Prevent duplicate submissions
            btnUpdate.Enabled = false;

            string? oldImagePath = _product.ImagePath;

            try
            {
                UpdateProductData();

                // Update Product Asynchronously
                await _productService.UpdateProductAsync(
                    _product.ProductId,
                    _product.Name,
                    _product.Price,
                    _product.StockQuantity,
                    _product.CategoryId,
                    _product.ImagePath
                );

                // Delete old image only after a successful update
                if (!string.IsNullOrWhiteSpace(oldImagePath) &&
                    oldImagePath != _product.ImagePath)
                {
                    try
                    {
                        DeleteOldImage(oldImagePath);
                    }
                    catch (Exception imageEx)
                    {
                        // The database update succeeded;
                        // log image cleanup errors separately.
                        System.Diagnostics.Debug.WriteLine(
                            imageEx.ToString()
                        );
                    }
                }

                MessageBox.Show(
                    "Product updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                // Restore the original image path if saving fails
                _product.ImagePath = oldImagePath;

                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    ex.Message,
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_newImagePath))
            {
                DeleteOldImage(_newImagePath);
            }

            DialogResult = DialogResult.Cancel;
        }
    }
}

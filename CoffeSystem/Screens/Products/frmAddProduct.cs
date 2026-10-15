
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmAddProduct : Form
    {
        private readonly CategoryService _categoryService;
        private readonly ProductService _productService;
        private readonly ProductImageService _productImageService;
        private string? _imagePath;

        public frmAddProduct()
        {
            InitializeComponent();

            _categoryService = CreateCategoryService();
            _productService = CreateProductService();
            _productImageService = CreateProductImageService();
            Shown += frmAddProduct_Shown;

        }

        //
        private async void frmAddProduct_Shown(object sender,EventArgs e)
        {
            btnAdd.Enabled = false;

            try
            {
                await LoadCategoriesAsync();

                if (cmbCategory.Items.Count == 0)
                {
                    MessageBox.Show(
                        "Please add a category before adding a product.",
                        "No Categories",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "Unable to load categories. Please try again.",
                    "Categories Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            btnAdd.Enabled = true;
        }
        // Methode N°1
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // Methode N°2
        private async Task LoadCategoriesAsync()
        {
            var categories =
                await _categoryService.GetAllCategoriesAsync();

            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
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
        private ProductImageService CreateProductImageService()
        {
            string imagesFolder =
                Path.Combine(
                    Directory.GetParent(
                        Application.StartupPath
                    )!.Parent!.Parent!.Parent!.FullName,
                    "Images",
                    "Products"
                );

            return new ProductImageService(imagesFolder);
        }

        // Methode N°5
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

        // Methode N°6
        private Product CreateProductFromForm()
        {
            return new Product
            {
                Name = txtProductName.Text,
                Price = nudPrice.Value,
                StockQuantity = (int)nudStock.Value,
                CategoryId = Convert.ToInt32(
                    cmbCategory.SelectedValue
                ),
                ImagePath = _imagePath
            };
        }

        // Methode N° 7
        private void DeleteSelectedImage()
        {
            ClearProductImage();

            if (string.IsNullOrWhiteSpace(_imagePath))
                return;

            string fullPath = Path.Combine(
                Directory.GetParent(
                    Application.StartupPath
                )!.Parent!.Parent!.Parent!.FullName,
                _imagePath
            );

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            _imagePath = null;
        }

        // Methode N°8
        private void ClearProductImage()
        {
            if (picProduct.Image != null)
            {
                picProduct.Image.Dispose();
                picProduct.Image = null;
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
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

                string fullPath = Path.Combine(
                    Directory.GetParent(
                        Application.StartupPath
                    )!.Parent!.Parent!.Parent!.FullName,
                    _imagePath
                );

                picProduct.Image = LoadImageWithoutLock(fullPath);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            // Prevent duplicate submissions
            btnAdd.Enabled = false;

            try
            {
                Product product = CreateProductFromForm();

                await _productService.AddProductAsync(product);

                MessageBox.Show(
                    "Product added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                _imagePath = null;

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                DeleteSelectedImage();

                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnAdd.Enabled = true;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DeleteSelectedImage();

            DialogResult = DialogResult.Cancel;
        }
    }
}

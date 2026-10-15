
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmAddCategory : Form
    {
        private readonly CategoryService _categoryService;
        private bool _isAdding;

        public frmAddCategory()
        {
            InitializeComponent();

            _categoryService = CreateCategoryService();
        }

        // Methode N°1 : Create Category Service
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        private void frmAddCategory_Load(object sender, EventArgs e)
        {
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            // Case 1 : check if name is empty
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show(
                    "Category name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtName.Focus();
                return;
            }

            // Prevent duplicate submissions
            if (_isAdding)
                return;

            _isAdding = true;
            btnAdd.Enabled = false;

            try
            {
                // Case 2 : Check if name already exists on system
                bool nameExists = await _categoryService.CategoryNameExistsAsync(name);

                if (nameExists)
                {
                    MessageBox.Show(
                        "This category name already exists.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtName.Focus();
                    return;
                }

                // Case 3 : Check if description is empty
                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show(
                        "Category description is required.",
                        "Validation",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtDescription.Focus();
                    return;
                }

                // Create category object
                Category category = new Category
                {
                    Name = name,
                    Description = description
                };

                // Add category to database
                await _categoryService.AddCategoryAsync(category);

                MessageBox.Show(
                    "Category added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "An error occurred while adding the category. Please try again.",
                    "Add Category Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _isAdding = false;

                if (!IsDisposed)
                {
                    btnAdd.Enabled = true;
                }
            }
        }
    }
}


using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmEditCategory : Form
    {
        private readonly CategoryService _categoryService;
        private readonly int _categoryId;
        private bool _isSaving;

        public frmEditCategory(int categoryId)
        {
            InitializeComponent();

            _categoryService = CreateCategoryService();

            _categoryId = categoryId;

            // Load the category asynchronously when the form appears
            Shown += frmEditCategory_Shown;
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
        private async Task LoadCategoryAsync()
        {
            Category? category =
                await _categoryService.GetCategoryByIdAsync(
                    _categoryId
                );

            if (category == null)
            {
                MessageBox.Show(
                    "Category not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            txtName.Text = category.Name;
            txtDescription.Text = category.Description;
        }

        // Load Category Event
        private async void frmEditCategory_Shown( object sender, EventArgs e)
        {
            try
            {
                await LoadCategoryAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "An error occurred while loading the category.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void frmEditCategory_Load( object sender,EventArgs e)
        {
        }

        private async void btnSave_Click( object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            // Validation Category Name
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

            // Validation Description
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

            // Prevent duplicate submissions
            if (_isSaving)
                return;

            _isSaving = true;
            btnSave.Enabled = false;

            try
            {
                await _categoryService.UpdateCategoryAsync(
                    _categoryId,
                    name,
                    description
                );

                MessageBox.Show(
                    "Category updated successfully.",
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
                    "An error occurred while updating the category.",
                    "Update Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                _isSaving = false;

                if (!IsDisposed)
                {
                    btnSave.Enabled = true;
                }
            }
        }
    }
}

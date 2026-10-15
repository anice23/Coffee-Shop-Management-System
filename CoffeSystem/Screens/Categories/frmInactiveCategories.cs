
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
    public partial class frmInactiveCategories : Form
    {
        private CategoryService _categoryService;

        // Keep inactive categories in memory for live search
        private List<Category> _allInactiveCategories = new List<Category>();

        private bool _isProcessingRestore;

        public frmInactiveCategories()
        {
            InitializeComponent();

            _categoryService = CreateCategoryService();

            ConfigureDataGrid();

            // Keep only one TextChanged subscription.
            // If this event is already bound in the Designer,
            // remove that Designer binding.
            txtSearch.TextChanged += txtSearch_TextChanged;

            // Initial data loading is handled by the existing Load event.
        }

        // Methode N°1
        private void ConfigureDataGrid()
        {
            dgvInactiveCategories.AutoGenerateColumns = false;
            dgvInactiveCategories.AllowUserToAddRows = false;
            dgvInactiveCategories.AllowUserToDeleteRows = false;
            dgvInactiveCategories.ReadOnly = true;

            dgvInactiveCategories.Columns.Clear();

            dgvInactiveCategories.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colCategoryId",
                    HeaderText = "ID",
                    DataPropertyName = "CategoryId",
                    Width = 80,
                    ReadOnly = true
                }
            );

            dgvInactiveCategories.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colCategoryName",
                    HeaderText = "Category Name",
                    DataPropertyName = "Name",
                    AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill,
                    ReadOnly = true
                }
            );

            dgvInactiveCategories.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colDescription",
                    HeaderText = "Description",
                    DataPropertyName = "Description",
                    Width = 300,
                    ReadOnly = true
                }
            );

            dgvInactiveCategories.Columns.Add(
                new DataGridViewButtonColumn
                {
                    Name = "colActions",
                    HeaderText = "Actions",
                    Text = "Restore",
                    UseColumnTextForButtonValue = true,
                    Width = 130,
                    ReadOnly = true
                }
            );
        }

        // Methode N°2
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // Methode N°3 : Load Inactive Categories
        private async Task LoadInactiveCategoriesAsync()
        {
            _allInactiveCategories =
                await _categoryService.GetInactiveCategoriesAsync();

            ApplyCategoryFilter();
        }

        // Apply live search in memory
        private void ApplyCategoryFilter()
        {
            string searchText = txtSearch.Text.Trim();

            List<Category> categories = _allInactiveCategories
                .Where(category =>
                    string.IsNullOrWhiteSpace(searchText) ||
                    category.Name.Contains(
                        searchText,
                        StringComparison.CurrentCultureIgnoreCase
                    )
                )
                .OrderBy(category => category.Name)
                .ToList();

            dgvInactiveCategories.Rows.Clear();

            // Case 3
            if (categories.Count == 0)
            {
                lblNoResults.Visible = true;
                dgvInactiveCategories.Visible = false;
                return;
            }

            lblNoResults.Visible = false;
            dgvInactiveCategories.Visible = true;

            foreach (Category category in categories)
            {
                dgvInactiveCategories.Rows.Add(
                    category.CategoryId,
                    category.Name,
                    category.Description
                );
            }
        }

        // Safely load categories
        private async Task RefreshInactiveCategoriesSafelyAsync()
        {
            try
            {
                await LoadInactiveCategoriesAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل الأصناف المعطّلة. حاول مجددًا.",
                    "Categories Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void pnlHeader_Paint( object sender, PaintEventArgs e)
        {
        }

        private async void frmInactiveCategories_Load(object sender,EventArgs e)
        {
            await RefreshInactiveCategoriesSafelyAsync();
        }

        // Methode N°4 : Restore Category
        private async void dgvInactiveCategories_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvInactiveCategories.Columns[e.ColumnIndex].Name
                != "colActions")
            {
                return;
            }

            // Prevent duplicate restore operations
            if (_isProcessingRestore)
                return;

            int categoryId = Convert.ToInt32(
                dgvInactiveCategories.Rows[e.RowIndex]
                    .Cells["colCategoryId"]
                    .Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to restore this category?",
                "Restore Category",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result != DialogResult.Yes)
                return;

            _isProcessingRestore = true;
            dgvInactiveCategories.Enabled = false;

            try
            {
                await _categoryService.RestoreCategoryAsync(
                    categoryId
                );

                MessageBox.Show(
                    "Category restored successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Reload the inactive categories after restoring
                await RefreshInactiveCategoriesSafelyAsync();
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
                    dgvInactiveCategories.Enabled = true;
                }
            }
        }

        private void txtSearch_TextChanged(  object sender, EventArgs e)
        {
            ApplyCategoryFilter();
        }

        private void lblNoResults_Click(object sender,EventArgs e)
        {
        }
    }
}

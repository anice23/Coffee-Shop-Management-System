
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmCategories : Form
    {
        private CategoryService _categoryService;

        // Keep active categories in memory for live search
        private List<Category> _allCategories = new List<Category>();

        private bool _isProcessingCategoryAction;

        public frmCategories()
        {
            InitializeComponent();

            _categoryService = CreateCategoryService();

            ConfigureDataGrid();

            dgvCategories.CellPainting +=  dgvCategories_CellPainting;

            dgvCategories.CellMouseClick +=  dgvCategories_CellMouseClick;

            txtSearch.TextChanged +=txtSearch_TextChanged;

            // Categories are loaded asynchronously in frmCategories_Load.
        }

        // Methode N°1
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // Methode N°2 : Load Categories
        private async Task LoadCategoriesAsync()
        {
            _allCategories =  await _categoryService.GetAllCategoriesAsync();

            ApplyCategoryFilter();
        }

        // Load categories when the form opens
        private async void frmCategories_Load(object sender,EventArgs e)
        {
            await RefreshCategoriesSafelyAsync();
        }

        // Refresh Categories Safely
        private async Task RefreshCategoriesSafelyAsync()
        {
            try
            {
                await LoadCategoriesAsync();
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

        // Apply Search Filter In Memory
        private void ApplyCategoryFilter()
        {
            string searchText = txtSearch.Text.Trim();

            List<Category> categories = _allCategories
                .Where(category =>
                    string.IsNullOrWhiteSpace(searchText) ||
                    category.Name.Contains(
                        searchText,
                        StringComparison.CurrentCultureIgnoreCase
                    )
                )
                .OrderBy(category => category.Name)
                .ToList();

            dgvCategories.Rows.Clear();

            // Case if no categories found
            if (categories.Count == 0)
            {
                dgvCategories.Visible = false;
                lblNoResults.Visible = true;
                return;
            }

            dgvCategories.Visible = true;
            lblNoResults.Visible = false;

            foreach (Category category in categories)
            {
                dgvCategories.Rows.Add(
                    category.CategoryId,
                    category.Name
                );
            }

            dgvCategories.Refresh();
        }

        // Methode N°3
        private void ConfigureDataGrid()
        {
            dgvCategories.AutoGenerateColumns = false;
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ReadOnly = true;

            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    Name = "colCategoryId",
                    HeaderText = "ID",
                    DataPropertyName = "CategoryId",
                    Width = 80,
                    ReadOnly = true
                }
            );

            dgvCategories.Columns.Add(
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

            dgvCategories.Columns.Add(
                new DataGridViewButtonColumn
                {
                    Name = "colActions",
                    HeaderText = "Actions",
                    Text = "Edit",
                    UseColumnTextForButtonValue = false,
                    Width = 160,
                    ReadOnly = true
                }
            );
        }

        // Cell Painting
        private void dgvCategories_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex ==
                dgvCategories.Columns["colActions"].Index)
            {
                e.PaintBackground(e.CellBounds, true);

                // Edit button
                Rectangle editButton = new Rectangle(
                    e.CellBounds.X + 10,
                    e.CellBounds.Y + 5,
                    60,
                    e.CellBounds.Height - 10
                );

                // Delete button
                Rectangle deleteButton = new Rectangle(
                    e.CellBounds.X + 80,
                    e.CellBounds.Y + 5,
                    60,
                    e.CellBounds.Height - 10
                );

                ButtonRenderer.DrawButton(
                    e.Graphics,
                    editButton,
                    "Edit",
                    dgvCategories.Font,
                    false,
                    PushButtonState.Normal
                );

                ButtonRenderer.DrawButton(
                    e.Graphics,
                    deleteButton,
                    "Delete",
                    dgvCategories.Font,
                    false,
                    PushButtonState.Normal
                );

                e.Handled = true;
            }
        }

        // Cell Mouse Click
        private async void dgvCategories_CellMouseClick(object sender,DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex !=
                dgvCategories.Columns["colActions"].Index)
            {
                return;
            }

            // Prevent overlapping database operations
            if (_isProcessingCategoryAction)
                return;

            int categoryId = Convert.ToInt32(
                dgvCategories.Rows[e.RowIndex]
                    .Cells["colCategoryId"]
                    .Value
            );

            int relativeX = e.X;

            // Case (1) : Edit Category
            if (relativeX >= 10 && relativeX <= 70)
            {
                using (frmEditCategory frmEdit =
                    new frmEditCategory(categoryId))
                {
                    if (frmEdit.ShowDialog(this) == DialogResult.OK)
                    {
                        // Refresh the service after the dialog closes
                        _categoryService = CreateCategoryService();

                        await RefreshCategoriesSafelyAsync();
                    }
                }

                return;
            }

            // Case (2) : Deactivate Category
            if (relativeX >= 80 && relativeX <= 140)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to deactivate this category?",
                    "Deactivate Category",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                if (result != DialogResult.Yes)
                    return;

                _isProcessingCategoryAction = true;
                dgvCategories.Enabled = false;

                try
                {
                    await _categoryService.DeactivateCategoryAsync(
                        categoryId
                    );

                    MessageBox.Show(
                        "Category deactivated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    await RefreshCategoriesSafelyAsync();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(
                        ex.ToString()
                    );

                    MessageBox.Show(
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                finally
                {
                    _isProcessingCategoryAction = false;

                    if (!IsDisposed)
                    {
                        dgvCategories.Enabled = true;
                    }
                }
            }
        }

        private void frmCategories_Load_Empty(object sender,EventArgs e)
        {
            // Keep only if this handler is referenced by the Designer.
            // Remove the empty handler and its Designer binding if unused.
        }

        private async void btnInactiveCategories_Click( object sender, EventArgs e)
        {
            using (frmInactiveCategories frm =new frmInactiveCategories())
            {
                frm.ShowDialog(this);
            }

            _categoryService = CreateCategoryService();

            await RefreshCategoriesSafelyAsync();
        }

        private async void btnAddCategory_Click(object sender,EventArgs e)
        {
            using (frmAddCategory frmAdd =
                new frmAddCategory())
            {
                if (frmAdd.ShowDialog(this) == DialogResult.OK)
                {
                    _categoryService = CreateCategoryService();

                    await RefreshCategoriesSafelyAsync();
                }
            }
        }

        // Live Search
        private void txtSearch_TextChanged(object sender,EventArgs e)
        {
            ApplyCategoryFilter();
        }
    }
}

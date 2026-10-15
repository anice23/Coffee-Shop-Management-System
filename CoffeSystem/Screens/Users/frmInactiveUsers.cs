using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeSystem_1UI.Screens.Users
{
    public partial class frmInactiveUsers : Form
    {

        private UserService _userService;
        private CancellationTokenSource? _searchCancellationTokenSource;

        public frmInactiveUsers()
        {
            InitializeComponent();

            _userService = CreateUserService();


            dgvInactiveUsers.CellPainting += dgvInactiveUsers_CellPainting;
            dgvInactiveUsers.CellMouseClick += dgvInactiveUsers_CellMouseClicck;

            LoadInactiveUsers();

            txtSearch.TextChanged += txtSearch_TextChanged_1;

            lblNoResults.BringToFront();
        }

        // Methode N°1
        private UserService CreateUserService()
        {
            AppDbContext context = new AppDbContext();

            UserRepository repository =
                new UserRepository(context);

            return new UserService(repository);
        }

        // Methode N°2
        // Methode N°3
        private async Task LoadInactiveUsers(
           string searchText = "",
           CancellationToken cancellationToken = default)
        {
            try
            {
                List<User> users;

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    users =
                        await _userService.GetInactiveUsersAsync();
                }
                else
                {
                    users =
                        await _userService.SearchInactiveUsersAsync(
                            searchText);
                }

                cancellationToken.ThrowIfCancellationRequested();

                dgvInactiveUsers.Rows.Clear();

                if (users.Count == 0)
                {
                    dgvInactiveUsers.Visible = false;
                    lblNoResults.Visible = true;
                    return;
                }

                dgvInactiveUsers.Visible = true;
                lblNoResults.Visible = false;

                foreach (User user in users)
                {
                    dgvInactiveUsers.Rows.Add(
                        user.UserId,
                        user.UserName,
                        user.FullName,
                        user.Role);
                }

                dgvInactiveUsers.Refresh();
            }
            catch (OperationCanceledException)
            {
                // Search cancelled because a new search started.
            }
        }

        private void frmInactiveUsers_Load(object sender, EventArgs e)
        {

        }

        private async void dgvInactiveUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvInactiveUsers.Columns[e.ColumnIndex].Name != "colActions")
                return;

            e.PaintBackground(e.CellBounds, true);

            int buttonWidth = 90;
            int buttonHeight = 28;

            int startX =
                e.CellBounds.X +
                (e.CellBounds.Width - buttonWidth) / 2;

            int startY =
                e.CellBounds.Y +
                (e.CellBounds.Height - buttonHeight) / 2;

            Rectangle restoreButton =
                new Rectangle(
                    startX,
                    startY,
                    buttonWidth,
                    buttonHeight);

            ButtonRenderer.DrawButton(
                e.Graphics,
                restoreButton,
                "Restore",
                dgvInactiveUsers.Font,
                false,
                System.Windows.Forms.VisualStyles.PushButtonState.Normal);

            e.Handled = true;
        }

        private void dgvInactiveUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dgvInactiveUsers_CellMouseClicck(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.RowIndex >= dgvInactiveUsers.Rows.Count)
                return;

            if (e.ColumnIndex >= dgvInactiveUsers.Columns.Count)
                return;

            if (dgvInactiveUsers.Columns[e.ColumnIndex].Name != "colActions")
                return;

            DataGridViewRow row =
                dgvInactiveUsers.Rows[e.RowIndex];

            if (row.Cells["colUserId"].Value == null)
                return;

            int userId =
                Convert.ToInt32(
                    row.Cells["colUserId"].Value);

            int buttonWidth = 90;
            int buttonHeight = 28;

            int startX =
                (dgvInactiveUsers.Columns[e.ColumnIndex].Width
                 - buttonWidth) / 2;

            int startY =
                (row.Height - buttonHeight) / 2;

            Rectangle restoreButton =
                new Rectangle(
                    startX,
                    startY,
                    buttonWidth,
                    buttonHeight);

            if (!restoreButton.Contains(e.Location))
                return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to restore this user?",
                "Restore User",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                bool result = await _userService.RestoreUserAsync(userId);

                if (!result)
                {
                    MessageBox.Show(
                        "Failed to restore user.",
                        "Restore User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    "User restored successfully.",
                    "Restore User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _userService = CreateUserService();

                LoadInactiveUsers(txtSearch.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while restoring the user:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            _searchCancellationTokenSource?.Cancel();

            _searchCancellationTokenSource?.Dispose();

            _searchCancellationTokenSource =
                new CancellationTokenSource();

            CancellationToken cancellationToken =
                _searchCancellationTokenSource.Token;

            try
            {
                await Task.Delay(300, cancellationToken);

                await LoadInactiveUsers(
                    txtSearch.Text.Trim(),
                    cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Search cancelled because a new search started.
            }

        }
    }

}

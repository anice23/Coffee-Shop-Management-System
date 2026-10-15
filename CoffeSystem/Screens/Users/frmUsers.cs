using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
namespace CoffeSystem_1UI.Screens.Users
{
    public partial class frmUsers : Form
    {
        private UserService _userService;
        private CancellationTokenSource _searchCancellationTokenSource;
        private readonly int _currentUserId;
        private readonly string _currentUserRole;
        public frmUsers(int currentUserId, string currentUserRole)
        {
            InitializeComponent();
            _userService = CreateUserService();
            _currentUserId = currentUserId;
            _currentUserRole = currentUserRole;
            //   ConfigureDataGrid();
            LoadUsers();

            txtSearch.TextChanged += txtSearch_TextChanged;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            dgvUsers.CellMouseClick += dgvUsers_CellMouseClick;
        }

        // Methode N°1: Create UserService
        private UserService CreateUserService()
        {
            AppDbContext context = new AppDbContext();

            UserRepository repository =
                new UserRepository(context);

            return new UserService(repository);
        }

        // Methode N°2 : Configure DataGrid
        //  private void ConfigureDataGrid()
        //{
        //    dgvUsers.AutoGenerateColumns = false;

        //    dgvUsers.AllowUserToAddRows = false;
        //    dgvUsers.AllowUserToDeleteRows = false;

        //    dgvUsers.ReadOnly = true;

        //    dgvUsers.SelectionMode =
        //        DataGridViewSelectionMode.FullRowSelect;

        //    dgvUsers.MultiSelect = false;

        //    dgvUsers.RowHeadersVisible = false;

        //    dgvUsers.BackgroundColor = Color.White;

        //    dgvUsers.BorderStyle = BorderStyle.None;

        //    dgvUsers.EnableHeadersVisualStyles = false;

        //    dgvUsers.ColumnHeadersDefaultCellStyle.BackColor =
        //        Color.FromArgb(62, 39, 35);

        //    dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor =
        //        Color.White;

        //    dgvUsers.ColumnHeadersDefaultCellStyle.Font =
        //        new Font("Segoe UI", 10, FontStyle.Bold);

        //    dgvUsers.ColumnHeadersHeight = 40;

        //    dgvUsers.RowTemplate.Height = 40;
        //}

        // Methode N°3 :Load Users
        private async Task LoadUsers(string searchText = "", CancellationToken cancellationToken = default)
        {
            dgvUsers.Rows.Clear();

            List<User> users;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                users = await _userService.GetAllUsersAsync();
            }
            else
            {
                users = await _userService.SearchUsersAsync(searchText);
            }
            cancellationToken.ThrowIfCancellationRequested();
            dgvUsers.Rows.Clear();

            if (users.Count == 0)
            {
                dgvUsers.Visible = false;
                lblNoResults.Visible = true;
                return;
            }

            dgvUsers.Visible = true;
            lblNoResults.Visible = false;

            foreach (User user in users)
            {
                dgvUsers.Rows.Add(
                    user.UserId,
                    user.UserName,
                    user.FullName,
                    user.Role
                );
            }

            dgvUsers.Refresh();
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
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

                await LoadUsers(txtSearch.Text.Trim(), cancellationToken);
            }
            catch (OperationCanceledException)
            {
                // Search cancelled because a new search started.
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // Methode : Event for drawing actions buttons
        private void dgvUsers_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 ||
        e.ColumnIndex < 0)
            {
                return;
            }

            if (dgvUsers.Columns[e.ColumnIndex].Name != "colActions")
            {
                return;
            }

            e.PaintBackground(e.CellBounds, true);

            int buttonWidth = 85;
            int buttonHeight = 28;
            int spacing = 8;

            int totalWidth =
                (buttonWidth * 2) + spacing;

            int startX =
                e.CellBounds.X +
                (e.CellBounds.Width - totalWidth) / 2;

            int startY =
                e.CellBounds.Y +
                (e.CellBounds.Height - buttonHeight) / 2;

            Rectangle editButton = new Rectangle(
                startX,
                startY,
                buttonWidth,
                buttonHeight
            );

            Rectangle deactivateButton = new Rectangle(
                startX + buttonWidth + spacing,
                startY,
                buttonWidth,
                buttonHeight
            );

            ButtonRenderer.DrawButton(
                e.Graphics,
                editButton,
                "Edit",
                dgvUsers.Font,
                false,
                System.Windows.Forms.VisualStyles.PushButtonState.Normal
            );

            ButtonRenderer.DrawButton(
                e.Graphics,
                deactivateButton,
                "Deactivate",
                dgvUsers.Font,
                false,
                System.Windows.Forms.VisualStyles.PushButtonState.Normal
            );

            e.Handled = true;
        }


        // Methode : event for detecting buttons what do ( edit & delete )
        private async void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (e.RowIndex >= dgvUsers.Rows.Count)
                return;

            if (e.ColumnIndex >= dgvUsers.Columns.Count)
                return;

            if (dgvUsers.Columns[e.ColumnIndex].Name != "colActions")
                return;

            DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

            if (row.Cells["colUserId"].Value == null)
                return;

            int userId = Convert.ToInt32(
                row.Cells["colUserId"].Value);

            int buttonWidth = 70;
            int buttonHeight = 28;
            int spacing = 8;

            int totalWidth = (buttonWidth * 2) + spacing;

            int startX =
                (dgvUsers.Columns[e.ColumnIndex].Width - totalWidth) / 2;

            int startY =
                (row.Height - buttonHeight) / 2;

            Rectangle editButton =
                new Rectangle(
                    startX,
                    startY,
                    buttonWidth,
                    buttonHeight);

            Rectangle deactivateButton =
                new Rectangle(
                    startX + buttonWidth + spacing,
                    startY,
                    buttonWidth,
                    buttonHeight);

            // Edit User Task
            if (editButton.Contains(e.Location))
            {
                using (frmEditUser frm = new frmEditUser(userId))
                {
                    DialogResult result = frm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        _userService = CreateUserService();

                        LoadUsers(txtSearch.Text.Trim());
                    }
                }

                return;
            }

            // Desactivate User Task
            if (deactivateButton.Contains(e.Location))
            {
                DialogResult confirm = MessageBox.Show(
                    "Are you sure you want to deactivate this user?",
                    "Deactivate User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm != DialogResult.Yes)
                    return;

                var result =
                    await _userService.DeactivateUserAsync(userId);

                if (!result.isSuccess)
                {
                    MessageBox.Show(
                        result.message,
                        "Deactivate User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    result.message,
                    "Deactivate User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                _userService = CreateUserService();

                LoadUsers(txtSearch.Text.Trim());
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using (frmAddUser frmAddUser = new frmAddUser(_currentUserId))
            {
                frmAddUser.ShowDialog(this);
            }
            _userService = CreateUserService();
            LoadUsers(txtSearch.Text.Trim());

        }

        private void btnInactiveUsers_Click(object sender, EventArgs e)
        {
            using (frmInactiveUsers frmInactive = new frmInactiveUsers())
            {
                frmInactive.ShowDialog(this);
            }
            _userService = CreateUserService();
            LoadUsers(txtSearch.Text.Trim());
        }
    }
}

using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Screens.Users
{
    public partial class frmEditUser : Form
    {
        private readonly UserService _userService;
        private readonly int _userId;
        private User? _user;
        public frmEditUser(int userId)
        {
            InitializeComponent();

            _userId = userId;
            _userService = CreateUserService();
            LoadUser();
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
        private async void LoadUser()
        {
            try
            {
                User? user =
                    await _userService.GetUserByIdAsync(_userId);

                if (user == null)
                {
                    MessageBox.Show(
                        "User not found.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    Close();
                    return;
                }

                _user = user;

                txtUserName.Text = user.UserName;

                txtFullName.Text = user.FullName;

                cbRole.Items.Clear();

                cbRole.Items.Add("Admin");
                cbRole.Items.Add("Cashier");

                cbRole.SelectedItem = user.Role;

                // System User protection
                if (user.IsSystemUser)
                {
                    txtUserName.Enabled = false;
                    cbRole.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ أثناء تحميل المستخدم:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                Close();
            }
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private async void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string newPassword = txtPassword.Text;
            string role = cbRole.SelectedItem?.ToString() ?? "";

            // Validation
            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show(
                    "Username is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Full name is required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cbRole.Focus();
                return;
            }

            try
            {
                string passwordHash = "";

                // Password is optional
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    passwordHash =
                        BCrypt.Net.BCrypt.HashPassword(newPassword);
                }

                var result =
                    await _userService.UpdateUserAsync(
                        _userId,
                        userName,
                        fullName,
                        passwordHash,
                        role);

                if (!result.IsSuccess)
                {
                    MessageBox.Show(
                        result.Message,
                        "Update User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MessageBox.Show(
                    result.Message,
                    "Update User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while updating the user:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}

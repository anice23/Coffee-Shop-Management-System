using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;

namespace CoffeSystem_1UI.Screens.Users
{
    public partial class frmAddUser : Form
    {
        private readonly UserService _userService;
        private readonly int _currentUserId;

        public frmAddUser(int currentUserId)
        {
            InitializeComponent();

            _userService = CreateUserService();
            _currentUserId = currentUserId;


            ConfigureRoleComboBox();

        }

        // =========================================================
        // UserService
        // =========================================================

        private UserService CreateUserService()
        {
            AppDbContext context = new AppDbContext();

            UserRepository repository =
                new UserRepository(context);

            return new UserService(repository);
        }

        // =========================================================
        // Form Configuration
        // =========================================================

        
        // =========================================================
        // Role ComboBox
        // =========================================================

        private void ConfigureRoleComboBox()
        {
            cbRole.Items.Clear();

            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Cashier");

            cbRole.SelectedIndex = 1;
        }

        // =========================================================
        // Save User
        // =========================================================

 

        private void frmAddUser_Load(object sender, EventArgs e)
        {

        }

        private  async void btnSave_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();

            string fullName = txtFullName.Text.Trim();

            string password = txtPassword.Text;

            string confirmPassword =txtConfirmPassword.Text;

            string role =cbRole.SelectedItem?.ToString() ?? "";

            // -----------------------------------------------------
            // Validation
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(userName))
            {
                MessageBox.Show(
                    "Please enter a username.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUserName.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show(
                    "Please enter the full name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();

                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter a password.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();

                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Focus();

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
            btnSave.Enabled = false;

            try
            {
                // -------------------------------------------------
                // Create User Entity
                // -------------------------------------------------

                User newUser = new User
                {
                    UserName = userName,
                    FullName = fullName,
                    Role = role,
                    IsActive = true,
                    IsSystemUser = false
                };

                // -------------------------------------------------
                // Register User
                // -------------------------------------------------
                var result = await _userService.RegisterUserAsync( newUser, password, _currentUserId
);


                // -------------------------------------------------
                // Failed
                // -------------------------------------------------

                if (!result.IsSuccess)
                {
                    MessageBox.Show(
                        result.Message,
                        "Add User",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // -------------------------------------------------
                // Success
                // -------------------------------------------------

                MessageBox.Show(
                    result.Message,
                    "Add User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;

                Close();
            }
            catch (Exception ex)
            {

                // Keep technical details for debugging
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّرت إضافة المستخدم. حاول مجددًا.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnSave.Enabled = true;
                }
            }
        }

        private async  void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();

        }
    }
}

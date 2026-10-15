using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Login_Register_Screen
{
    public partial class frmRegisterScreen : Form
    {
        private readonly UserService _userService;

        public frmRegisterScreen()
        {
            InitializeComponent();

            AppDbContext context = new AppDbContext();

            UserRepository repository =
                new UserRepository(context);

            _userService =
                new UserService(repository);
        }

        private void RegisterScreen_Load(
            object sender,
            EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtConfirmPassword.UseSystemPasswordChar = true;

            cbRole.Items.Clear();

            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Cashier");
        }

        private bool ValidateInputs()
        {
            errorProvider1.Clear();

            bool isValid = true;

            // UserName
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                errorProvider1.SetError(
                    txtUserName,
                    "هذه الخانة مطلوبة (Required)"
                );

                isValid = false;
            }

            // FullName
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                errorProvider1.SetError(
                    txtFullName,
                    "هذه الخانة مطلوبة (Required)"
                );

                isValid = false;
            }

            // Password
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider1.SetError(
                    txtPassword,
                    "هذه الخانة مطلوبة (Required)"
                );

                isValid = false;
            }

            // Confirm Password
            if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                errorProvider1.SetError(
                    txtConfirmPassword,
                    "هذه الخانة مطلوبة (Required)"
                );

                isValid = false;
            }

            // Role
            if (cbRole.SelectedIndex == -1)
            {
                errorProvider1.SetError(
                    cbRole,
                    "يرجى اختيار الدور (Required)"
                );

                isValid = false;
            }

            // Password confirmation
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) &&
                txtPassword.Text != txtConfirmPassword.Text)
            {
                errorProvider1.SetError(
                    txtConfirmPassword,
                    "كلمة المرور غير متطابقة!"
                );

                isValid = false;
            }

            return isValid;
        }


        // Save User
        private async void btnSave_Click( object sender, EventArgs e)
        {
            // Validation
            if (!ValidateInputs())
            {
                return;
            }

            // Make the data in User Oject
            User newUser = new User
            {
                UserName = txtUserName.Text.Trim(),
                FullName = txtFullName.Text.Trim(),
                Role = cbRole.SelectedItem.ToString().Trim()
            };

            string rawPassword = txtPassword.Text.Trim() ;

            try
            {
                btnSave.Enabled = false;
                var result = await _userService.RegisterUserAsync( newUser, rawPassword,0);

                if (result.IsSuccess)
                {
                    MessageBox.Show(
                        result.Message,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        result.Message,
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ غير متوقع: {ex.Message}",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private void txtUserName_TextChanged( object sender,EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender,EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender,EventArgs e)
        {
            Close();
        }

        private void lblWelcomeDescription_Click( object sender, EventArgs e)
        {
        }

        private void pnlTopBar_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void txtPassword_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void chkShowPassword_CheckedChanged(
            object sender,
            EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;

            txtConfirmPassword.UseSystemPasswordChar =
                !chkShowPassword.Checked;
        }
    }
}
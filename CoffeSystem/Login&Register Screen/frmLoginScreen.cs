using CoffeSystem_1UI.Login_Register_Screen;
using CoffeSystem_1UI.mainForm;
using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoffeSystem_1UI.Login_Screen
{
    public partial class frmLoginScreen : Form
    {
        private readonly UserService _userService;

        // The Constructor
        public frmLoginScreen()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;

            AppDbContext context = new AppDbContext();
            UserRepository repository = new UserRepository(context);
            _userService =new UserService(repository);
            chkShowPassword.Checked = true;
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
        }


        // close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // checkbox for showing passwword
        private void chkShowPassword_CheckedChanged( object sender,EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =!chkShowPassword.Checked;
        }

        private void btnLogin_MouseClick( object sender, MouseEventArgs e)
        {
        }

        // when login button leave => change backColor
        private void btnLogin_MouseLeave(object sender,EventArgs e)
        {
            btnLogin.BackColor =Color.FromArgb(109, 76, 65);
        }

        // when login button enter => change Backcolor
        private void btnLogin_MouseEnter( object sender, EventArgs e)
        {
            btnLogin.BackColor =Color.FromArgb(78, 52, 46);
        }

        // 
        private void btnRegister_MouseEnter(object sender,EventArgs e)
        {
            btnRegister.ForeColor =Color.FromArgb(92, 105, 54);
        }

        private void btnRegister_MouseLeave(object sender,EventArgs e)
        {
            btnRegister.ForeColor = Color.FromArgb(122, 139, 74);

        }

        // Login methode
        private async void btnLogin_Click(object sender,EventArgs e)
        {
            string username =txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validation if  username or password are empty ?
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "يرجى إدخال اسم المستخدم وكلمة المرور.",
                    "بيانات ناقصة",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Prevent double click
            btnLogin.Enabled = false;

            try
            {
                // call the loginAsync methode 
                var result = await _userService.LoginAsync(username, password);
                // if result.IsSuccess = true && result.user != null => open mainForm :
                if (result.IsSuccess && result.user != null)
                {
                    frmMain frm = new frmMain(
                         this,
                        result.user.UserId,
                        result.user.UserName,
                         result.user.Role
                    );

                    frm.Show();
                    Hide();
                }

                // if failed :
                else
                {
                    MessageBox.Show(
                        $"Login Failed!\n{result.Message}",
                        "فشل تسجيل الدخول",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"حدث خطأ غير متوقع: {ex.Message}",
                    "خطأ في النظام",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        private void pnlLogin_Paint(object sender,PaintEventArgs e)
        {
        }

        // Register Button
        private void btnRegister_Click( object sender,EventArgs e)
        {
            frmRegisterScreen frm = new frmRegisterScreen();
            frm.ShowDialog();
        }

        private void pnlTopBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
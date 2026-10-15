using System.Windows.Forms;

namespace CoffeSystem_1UI.Login_Screen
{
    partial class frmLoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginScreen));
            pnlLogin = new Panel();
            chkShowPassword = new CheckBox();
            btnRegister = new Button();
            lblNoAccount = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblLoginSubtitle = new Label();
            lblLoginTitle = new Label();
            pnlTopBar = new Panel();
            btnClose = new Button();
            lblAppTitle = new Label();
            pnlWelcome = new Panel();
            lblWelcomeDescription = new Label();
            lblWelcomeTitle = new Label();
            picLogo = new PictureBox();
            pnlLogin.SuspendLayout();
            pnlTopBar.SuspendLayout();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.FromArgb(245, 241, 236);
            pnlLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlLogin.Controls.Add(chkShowPassword);
            pnlLogin.Controls.Add(btnRegister);
            pnlLogin.Controls.Add(lblNoAccount);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(txtUserName);
            pnlLogin.Controls.Add(lblUserName);
            pnlLogin.Controls.Add(lblLoginSubtitle);
            pnlLogin.Controls.Add(lblLoginTitle);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(1400, 800);
            pnlLogin.TabIndex = 0;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(121, 85, 72);
            chkShowPassword.Location = new Point(761, 548);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(151, 27);
            chkShowPassword.TabIndex = 18;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Transparent;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.FromArgb(122, 139, 74);
            btnRegister.Location = new Point(875, 666);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(158, 45);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Create Account";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoAccount.ForeColor = Color.FromArgb(121, 85, 72);
            lblNoAccount.Location = new Point(771, 640);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(195, 23);
            lblNoAccount.TabIndex = 16;
            lblNoAccount.Text = " Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(109, 76, 65);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(746, 581);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 45);
            btnLogin.TabIndex = 15;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseClick += btnLogin_MouseClick;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(746, 508);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 34);
            txtPassword.TabIndex = 14;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(62, 39, 35);
            lblPassword.Location = new Point(746, 465);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 25);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(746, 407);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 34);
            txtUserName.TabIndex = 12;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(62, 39, 35);
            lblUserName.Location = new Point(746, 357);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(96, 25);
            lblUserName.TabIndex = 11;
            lblUserName.Text = "Username";
            // 
            // lblLoginSubtitle
            // 
            lblLoginSubtitle.AutoSize = true;
            lblLoginSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginSubtitle.ForeColor = Color.FromArgb(121, 85, 72);
            lblLoginSubtitle.Location = new Point(706, 255);
            lblLoginSubtitle.Name = "lblLoginSubtitle";
            lblLoginSubtitle.Size = new Size(360, 28);
            lblLoginSubtitle.TabIndex = 10;
            lblLoginSubtitle.Text = "Sign in to continue to Coffee System";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginTitle.ForeColor = Color.FromArgb(62, 39, 35);
            lblLoginTitle.Location = new Point(706, 168);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(327, 60);
            lblLoginTitle.TabIndex = 9;
            lblLoginTitle.Text = "Welcome Back";
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(62, 39, 35);
            pnlTopBar.Controls.Add(btnClose);
            pnlTopBar.Controls.Add(lblAppTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1400, 45);
            pnlTopBar.TabIndex = 2;
            pnlTopBar.Paint += pnlTopBar_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(62, 39, 35);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1351, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 6;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.BackColor = Color.Transparent;
            lblAppTitle.Font = new Font("Wondercity", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(18, 10);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(177, 25);
            lblAppTitle.TabIndex = 5;
            lblAppTitle.Text = "☕  Coffee System";
            // 
            // pnlWelcome
            // 
            pnlWelcome.BackColor = Color.FromArgb(62, 39, 35);
            pnlWelcome.Controls.Add(lblWelcomeDescription);
            pnlWelcome.Controls.Add(lblWelcomeTitle);
            pnlWelcome.Controls.Add(picLogo);
            pnlWelcome.Dock = DockStyle.Left;
            pnlWelcome.Location = new Point(0, 45);
            pnlWelcome.Name = "pnlWelcome";
            pnlWelcome.Size = new Size(500, 755);
            pnlWelcome.TabIndex = 3;
            // 
            // lblWelcomeDescription
            // 
            lblWelcomeDescription.AutoSize = true;
            lblWelcomeDescription.BackColor = Color.Transparent;
            lblWelcomeDescription.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeDescription.ForeColor = Color.FromArgb(215, 204, 200);
            lblWelcomeDescription.Location = new Point(50, 313);
            lblWelcomeDescription.Name = "lblWelcomeDescription";
            lblWelcomeDescription.Size = new Size(306, 25);
            lblWelcomeDescription.TabIndex = 2;
            lblWelcomeDescription.Text = "Manage your coffee shop with ease";
            lblWelcomeDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.BackColor = Color.Transparent;
            lblWelcomeTitle.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTitle.ForeColor = Color.White;
            lblWelcomeTitle.Location = new Point(50, 253);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(320, 60);
            lblWelcomeTitle.TabIndex = 1;
            lblWelcomeTitle.Text = "Coffee System";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(120, 94);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(171, 156);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // frmLoginScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1400, 800);
            Controls.Add(pnlWelcome);
            Controls.Add(pnlTopBar);
            Controls.Add(pnlLogin);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "frmLoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee System";
            Load += LoginScreen_Load;
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogin;
        private Panel pnlTopBar;
        private Label lblAppTitle;
        private Button btnClose;
        private Panel pnlWelcome;
        private Label lblWelcomeDescription;
        private Label lblWelcomeTitle;
        private PictureBox picLogo;
        private Label lblLoginTitle;
        private Label lblLoginSubtitle;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label lblNoAccount;
        private CheckBox chkShowPassword;
    }
}
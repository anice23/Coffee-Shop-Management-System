using System.Windows.Forms;

namespace CoffeSystem_1UI.Login_Register_Screen
{
    partial class frmRegisterScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterScreen));
            errorProvider1 = new ErrorProvider(components);
            pnlTopBar = new Panel();
            lblAppTitle = new Label();
            btnClose = new Button();
            pnlWelcome = new Panel();
            lblWelcomeDescription = new Label();
            lblWelcomeTitle = new Label();
            picLogo = new PictureBox();
            pnlRegister = new Panel();
            chkShowPassword = new CheckBox();
            btnSave = new Button();
            cbRole = new ComboBox();
            lblRole = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            pnlTopBar.SuspendLayout();
            pnlWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pnlTopBar
            // 
            pnlTopBar.BackColor = Color.FromArgb(62, 39, 35);
            pnlTopBar.Controls.Add(lblAppTitle);
            pnlTopBar.Dock = DockStyle.Top;
            pnlTopBar.Location = new Point(0, 0);
            pnlTopBar.Name = "pnlTopBar";
            pnlTopBar.Size = new Size(1400, 45);
            pnlTopBar.TabIndex = 0;
            pnlTopBar.Paint += pnlTopBar_Paint;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.BackColor = Color.Transparent;
            lblAppTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(12, 9);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(184, 28);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "☕  Coffee System";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(62, 39, 35);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1355, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(45, 45);
            btnClose.TabIndex = 1;
            btnClose.Text = "×";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
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
            pnlWelcome.Size = new Size(498, 755);
            pnlWelcome.TabIndex = 2;
            // 
            // lblWelcomeDescription
            // 
            lblWelcomeDescription.AutoSize = true;
            lblWelcomeDescription.BackColor = Color.Transparent;
            lblWelcomeDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeDescription.ForeColor = Color.FromArgb(215, 204, 200);
            lblWelcomeDescription.Location = new Point(19, 300);
            lblWelcomeDescription.Name = "lblWelcomeDescription";
            lblWelcomeDescription.Size = new Size(479, 23);
            lblWelcomeDescription.TabIndex = 3;
            lblWelcomeDescription.Text = "Create your account and manage your coffee shop with ease";
            lblWelcomeDescription.TextAlign = ContentAlignment.MiddleCenter;
            lblWelcomeDescription.Click += lblWelcomeDescription_Click;
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.AutoSize = true;
            lblWelcomeTitle.BackColor = Color.Transparent;
            lblWelcomeTitle.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcomeTitle.ForeColor = Color.White;
            lblWelcomeTitle.Location = new Point(105, 235);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new Size(364, 54);
            lblWelcomeTitle.TabIndex = 2;
            lblWelcomeTitle.Text = "Join Coffee System";
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(190, 90);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(120, 120);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlRegister
            // 
            pnlRegister.Controls.Add(chkShowPassword);
            pnlRegister.Controls.Add(btnSave);
            pnlRegister.Controls.Add(cbRole);
            pnlRegister.Controls.Add(lblRole);
            pnlRegister.Controls.Add(txtConfirmPassword);
            pnlRegister.Controls.Add(lblConfirmPassword);
            pnlRegister.Controls.Add(txtPassword);
            pnlRegister.Controls.Add(lblPassword);
            pnlRegister.Controls.Add(txtUserName);
            pnlRegister.Controls.Add(lblUserName);
            pnlRegister.Controls.Add(txtFullName);
            pnlRegister.Controls.Add(lblFullName);
            pnlRegister.Dock = DockStyle.Fill;
            pnlRegister.ForeColor = Color.FromArgb(62, 39, 35);
            pnlRegister.Location = new Point(498, 45);
            pnlRegister.Name = "pnlRegister";
            pnlRegister.Size = new Size(902, 755);
            pnlRegister.TabIndex = 3;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkShowPassword.ForeColor = Color.FromArgb(121, 85, 72);
            chkShowPassword.Location = new Point(180, 537);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(151, 27);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(109, 76, 65);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(180, 568);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(400, 45);
            btnSave.TabIndex = 10;
            btnSave.Text = "Create Account";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbRole
            // 
            cbRole.BackColor = Color.White;
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbRole.ForeColor = Color.FromArgb(62, 39, 35);
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(180, 495);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(400, 36);
            cbRole.TabIndex = 9;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(62, 39, 35);
            lblRole.Location = new Point(180, 470);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(49, 25);
            lblRole.TabIndex = 8;
            lblRole.Text = "Role";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.ForeColor = Color.FromArgb(62, 39, 35);
            txtConfirmPassword.Location = new Point(180, 420);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(400, 34);
            txtConfirmPassword.TabIndex = 7;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(62, 39, 35);
            lblConfirmPassword.Location = new Point(180, 395);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(162, 25);
            lblConfirmPassword.TabIndex = 6;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(62, 39, 35);
            txtPassword.Location = new Point(180, 345);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 34);
            txtPassword.TabIndex = 5;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(62, 39, 35);
            lblPassword.Location = new Point(180, 320);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(90, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.FromArgb(62, 39, 35);
            txtUserName.Location = new Point(180, 270);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 34);
            txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(62, 39, 35);
            lblUserName.Location = new Point(180, 245);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(96, 25);
            lblUserName.TabIndex = 2;
            lblUserName.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.FromArgb(62, 39, 35);
            txtFullName.Location = new Point(180, 190);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 34);
            txtFullName.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(62, 39, 35);
            lblFullName.Location = new Point(180, 165);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(96, 25);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // frmRegisterScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1400, 800);
            Controls.Add(pnlRegister);
            Controls.Add(pnlWelcome);
            Controls.Add(btnClose);
            Controls.Add(pnlTopBar);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1200, 700);
            Name = "frmRegisterScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee System";
            Load += RegisterScreen_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            pnlTopBar.ResumeLayout(false);
            pnlTopBar.PerformLayout();
            pnlWelcome.ResumeLayout(false);
            pnlWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRegister.ResumeLayout(false);
            pnlRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Panel pnlTopBar;
        private Button btnClose;
        private Label lblAppTitle;
        private Panel pnlWelcome;
        private PictureBox picLogo;
        private Label lblWelcomeDescription;
        private Label lblWelcomeTitle;
        private Panel pnlRegister;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private Button btnSave;
        private ComboBox cbRole;
        private Label lblRole;
        private CheckBox chkShowPassword;
    }
}
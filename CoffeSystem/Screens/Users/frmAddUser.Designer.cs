namespace CoffeSystem_1UI.Screens.Users
{
    partial class frmAddUser
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
            pnlContent = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cbRole = new ComboBox();
            lblRole = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            lblFullName = new Label();
            lblUserName = new Label();
            lblTitle = new Label();
            pnlHeader = new Panel();
            pnlContent.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(btnCancel);
            pnlContent.Controls.Add(btnSave);
            pnlContent.Controls.Add(cbRole);
            pnlContent.Controls.Add(lblRole);
            pnlContent.Controls.Add(txtConfirmPassword);
            pnlContent.Controls.Add(lblConfirmPassword);
            pnlContent.Controls.Add(txtPassword);
            pnlContent.Controls.Add(lblPassword);
            pnlContent.Controls.Add(txtFullName);
            pnlContent.Controls.Add(txtUserName);
            pnlContent.Controls.Add(lblFullName);
            pnlContent.Controls.Add(lblUserName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            pnlContent.Location = new Point(0, 53);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40, 20, 40, 20);
            pnlContent.Size = new Size(490, 447);
            pnlContent.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(111, 78, 55);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(247, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(78, 52, 46);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(61, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 40);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "", "Cashier" });
            cbRole.Location = new Point(40, 325);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(400, 36);
            cbRole.TabIndex = 10;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(111, 78, 55);
            lblRole.Location = new Point(40, 300);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 28);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Location = new Point(40, 255);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(400, 34);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(111, 78, 55);
            lblConfirmPassword.Location = new Point(40, 230);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(176, 28);
            lblConfirmPassword.TabIndex = 7;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(40, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 34);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(111, 78, 55);
            lblPassword.Location = new Point(40, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Location = new Point(40, 115);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 34);
            txtFullName.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Location = new Point(40, 45);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 34);
            txtUserName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(111, 78, 55);
            lblFullName.Location = new Point(40, 90);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(104, 28);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Full Name";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblUserName.ForeColor = Color.FromArgb(111, 78, 55);
            lblUserName.Location = new Point(40, 20);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 28);
            lblUserName.TabIndex = 1;
            lblUserName.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(129, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add User";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(490, 53);
            pnlHeader.TabIndex = 0;
            // 
            // frmAddUser
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(490, 500);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add User";
            Load += frmAddUser_Load;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlContent;
        private TextBox txtUserName;
        private Label lblFullName;
        private Label lblUserName;
        private Label lblRole;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtFullName;
        private Button btnSave;
        private ComboBox cbRole;
        private Button btnCancel;
        private Label lblTitle;
        private Panel pnlHeader;
    }
}
namespace CoffeSystem_1UI.Screens.Users
{
    partial class frmEditUser
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            cbRole = new ComboBox();
            lblRole = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            lblFullName = new Label();
            lblUserName = new Label();
            pnlHeader.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(488, 59);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit User";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(btnCancel);
            pnlContent.Controls.Add(btnSave);
            pnlContent.Controls.Add(cbRole);
            pnlContent.Controls.Add(lblRole);
            pnlContent.Controls.Add(txtPassword);
            pnlContent.Controls.Add(lblPassword);
            pnlContent.Controls.Add(txtFullName);
            pnlContent.Controls.Add(txtUserName);
            pnlContent.Controls.Add(lblFullName);
            pnlContent.Controls.Add(lblUserName);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 59);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(40, 20, 40, 20);
            pnlContent.Size = new Size(488, 445);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(141, 110, 99);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(239, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 40);
            btnCancel.TabIndex = 9;
            btnCancel.Text = " Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(78, 52, 46);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(53, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 40);
            btnSave.TabIndex = 8;
            btnSave.Text = " Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "", "Cashier" });
            cbRole.Location = new Point(40, 316);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(400, 31);
            cbRole.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.ForeColor = Color.FromArgb(62, 39, 35);
            lblRole.Location = new Point(40, 285);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 28);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(40, 251);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(400, 31);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(62, 39, 35);
            lblPassword.Location = new Point(40, 220);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(239, 28);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "New Password (optional)";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(40, 186);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 31);
            txtFullName.TabIndex = 3;
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.FixedSingle;
            txtUserName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(40, 115);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(400, 31);
            txtUserName.TabIndex = 2;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(62, 39, 35);
            lblFullName.Location = new Point(40, 155);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(104, 28);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(62, 39, 35);
            lblUserName.Location = new Point(40, 84);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(104, 28);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Username";
            lblUserName.Click += lblUserName_Click;
            // 
            // frmEditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(488, 504);
            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit User";
            Load += frmEditUser_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlContent;
        private TextBox txtUserName;
        private Label lblFullName;
        private Label lblUserName;
        private Label lblRole;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtFullName;
        private Button btnSave;
        private ComboBox cbRole;
        private Button btnCancel;
    }
}
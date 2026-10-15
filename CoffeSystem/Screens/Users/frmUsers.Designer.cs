namespace CoffeSystem_1UI.Screens.Users
{
    partial class frmUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            panel1 = new Panel();
            btnInactiveUsers = new Button();
            btnAddUser = new Button();
            lblTitle = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            lblNoResults = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 52, 46);
            panel1.Controls.Add(btnInactiveUsers);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 60);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnInactiveUsers
            // 
            btnInactiveUsers.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInactiveUsers.BackColor = Color.FromArgb(141, 110, 99);
            btnInactiveUsers.FlatAppearance.BorderSize = 0;
            btnInactiveUsers.FlatStyle = FlatStyle.Flat;
            btnInactiveUsers.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInactiveUsers.ForeColor = Color.White;
            btnInactiveUsers.Location = new Point(831, 14);
            btnInactiveUsers.Name = "btnInactiveUsers";
            btnInactiveUsers.Size = new Size(158, 40);
            btnInactiveUsers.TabIndex = 2;
            btnInactiveUsers.Text = "Inactive Users";
            btnInactiveUsers.UseVisualStyleBackColor = false;
            btnInactiveUsers.Click += btnInactiveUsers_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddUser.BackColor = Color.FromArgb(111, 78, 55);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(995, 14);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(158, 40);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "+ Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(254, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Users Management";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(pictureBox1);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 60);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1175, 75);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(62, 39, 35);
            txtSearch.Location = new Point(59, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(62, 39, 35);
            lblSearch.Location = new Point(59, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(109, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search User";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUserName, colFullName, colRole, colActions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.GridColor = Color.White;
            dgvUsers.Location = new Point(0, 135);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1175, 600);
            dgvUsers.TabIndex = 2;
            dgvUsers.CellContentClick += dataGridView1_CellContentClick;
            dgvUsers.CellMouseClick += dgvUsers_CellMouseClick;
            dgvUsers.CellPainting += dgvUsers_CellPainting;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "ID";
            colUserId.MinimumWidth = 6;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Width = 125;
            // 
            // colUserName
            // 
            colUserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUserName.HeaderText = "Username";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 150;
            // 
            // colActions
            // 
            colActions.HeaderText = "Actions";
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Width = 180;
            // 
            // lblNoResults
            // 
            lblNoResults.AutoSize = true;
            lblNoResults.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoResults.Location = new Point(252, 266);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(273, 41);
            lblNoResults.TabIndex = 3;
            lblNoResults.Text = "No Users founded ";
            lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
            lblNoResults.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1175, 735);
            Controls.Add(lblNoResults);
            Controls.Add(dgvUsers);
            Controls.Add(pnlSearch);
            Controls.Add(panel1);
            MinimumSize = new Size(900, 600);
            Name = "frmUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsers";
            WindowState = FormWindowState.Maximized;
            Load += Users_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel pnlSearch;
        private Label lblTitle;
        private Button btnInactiveUsers;
        private Button btnAddUser;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colActions;
        private Label lblNoResults;
        private PictureBox pictureBox1;
    }
}
namespace CoffeSystem_1UI.Screens.Users
{
    partial class frmInactiveUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInactiveUsers));
            pnlHeader = new Panel();
            lbTitle = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvInactiveUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUserName = new DataGridViewTextBoxColumn();
            colFullName = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colActions = new DataGridViewTextBoxColumn();
            lblNoResults = new Label();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInactiveUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lbTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(981, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(187, 37);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Inactive Users";
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.FromArgb(245, 241, 236);
            pnlSearch.Controls.Add(pictureBox1);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 60);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(981, 79);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(62, 39, 35);
            txtSearch.Location = new Point(59, 42);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(62, 39, 35);
            lblSearch.Location = new Point(59, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(119, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search User";
            // 
            // dgvInactiveUsers
            // 
            dgvInactiveUsers.AllowUserToAddRows = false;
            dgvInactiveUsers.AllowUserToDeleteRows = false;
            dgvInactiveUsers.AllowUserToResizeColumns = false;
            dgvInactiveUsers.AllowUserToResizeRows = false;
            dgvInactiveUsers.BackgroundColor = Color.White;
            dgvInactiveUsers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInactiveUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInactiveUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInactiveUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUserName, colFullName, colRole, colActions });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInactiveUsers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInactiveUsers.Dock = DockStyle.Fill;
            dgvInactiveUsers.Location = new Point(0, 139);
            dgvInactiveUsers.Name = "dgvInactiveUsers";
            dgvInactiveUsers.ReadOnly = true;
            dgvInactiveUsers.RowHeadersVisible = false;
            dgvInactiveUsers.RowHeadersWidth = 51;
            dgvInactiveUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInactiveUsers.Size = new Size(981, 311);
            dgvInactiveUsers.TabIndex = 2;
            dgvInactiveUsers.CellContentClick += dgvInactiveUsers_CellContentClick;
            dgvInactiveUsers.CellPainting += dgvInactiveUsers_CellPainting;
            // 
            // colUserId
            // 
            colUserId.HeaderText = "ID";
            colUserId.MinimumWidth = 6;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            colUserId.Width = 70;
            // 
            // colUserName
            // 
            colUserName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUserName.HeaderText = " Username";
            colUserName.MinimumWidth = 6;
            colUserName.Name = "colUserName";
            colUserName.ReadOnly = true;
            colUserName.Resizable = DataGridViewTriState.False;
            // 
            // colFullName
            // 
            colFullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFullName.HeaderText = "Full Name";
            colFullName.MinimumWidth = 6;
            colFullName.Name = "colFullName";
            colFullName.ReadOnly = true;
            colFullName.Resizable = DataGridViewTriState.False;
            // 
            // colRole
            // 
            colRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 6;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Resizable = DataGridViewTriState.False;
            // 
            // colActions
            // 
            colActions.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActions.HeaderText = "Actions";
            colActions.MinimumWidth = 6;
            colActions.Name = "colActions";
            colActions.ReadOnly = true;
            colActions.Resizable = DataGridViewTriState.False;
            // 
            // lblNoResults
            // 
            lblNoResults.AutoSize = true;
            lblNoResults.BackColor = Color.Transparent;
            lblNoResults.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoResults.ForeColor = Color.FromArgb(141, 110, 99);
            lblNoResults.Location = new Point(297, 274);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(324, 38);
            lblNoResults.TabIndex = 2;
            lblNoResults.Text = "No inactive users found.";
            lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
            lblNoResults.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmInactiveUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(981, 450);
            Controls.Add(lblNoResults);
            Controls.Add(dgvInactiveUsers);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInactiveUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inactive Users";
            Load += frmInactiveUsers_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInactiveUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lbTitle;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvInactiveUsers;
        private Label lblNoResults;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUserName;
        private DataGridViewTextBoxColumn colFullName;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colActions;
        private PictureBox pictureBox1;
    }
}
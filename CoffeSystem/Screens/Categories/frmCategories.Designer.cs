namespace CoffeSystem_1UI.Screens
{
    partial class frmCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategories));
            pnlHeader = new Panel();
            lblTitle = new Label();
            btnInactiveCategories = new Button();
            btnAddCategory = new Button();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvCategories = new DataGridView();
            colCategoryId = new DataGridViewTextBoxColumn();
            colCategoryName = new DataGridViewTextBoxColumn();
            lblNoResults = new Label();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1011, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(317, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Categories Management";
            // 
            // btnInactiveCategories
            // 
            btnInactiveCategories.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInactiveCategories.BackColor = Color.FromArgb(166, 123, 91);
            btnInactiveCategories.FlatAppearance.BorderSize = 0;
            btnInactiveCategories.FlatStyle = FlatStyle.Flat;
            btnInactiveCategories.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInactiveCategories.ForeColor = Color.White;
            btnInactiveCategories.Location = new Point(604, 16);
            btnInactiveCategories.Name = "btnInactiveCategories";
            btnInactiveCategories.Size = new Size(204, 40);
            btnInactiveCategories.TabIndex = 3;
            btnInactiveCategories.Text = "Inactive Categories";
            btnInactiveCategories.UseVisualStyleBackColor = false;
            btnInactiveCategories.Click += btnInactiveCategories_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCategory.BackColor = Color.FromArgb(111, 78, 55);
            btnAddCategory.FlatAppearance.BorderSize = 0;
            btnAddCategory.FlatStyle = FlatStyle.Flat;
            btnAddCategory.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = Color.White;
            btnAddCategory.Location = new Point(814, 16);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(170, 40);
            btnAddCategory.TabIndex = 2;
            btnAddCategory.Text = "+ Add Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(pictureBox1);
            pnlSearch.Controls.Add(btnAddCategory);
            pnlSearch.Controls.Add(btnInactiveCategories);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 60);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1011, 75);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(62, 39, 35);
            txtSearch.Location = new Point(47, 35);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(62, 39, 35);
            lblSearch.Location = new Point(25, 4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(160, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Category";
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.AllowUserToResizeColumns = false;
            dgvCategories.AllowUserToResizeRows = false;
            dgvCategories.BackgroundColor = Color.White;
            dgvCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { colCategoryId, colCategoryName });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategories.Dock = DockStyle.Fill;
            dgvCategories.Location = new Point(0, 135);
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersVisible = false;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(1011, 465);
            dgvCategories.TabIndex = 3;
            // 
            // colCategoryId
            // 
            colCategoryId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCategoryId.HeaderText = "ID";
            colCategoryId.MinimumWidth = 6;
            colCategoryId.Name = "colCategoryId";
            colCategoryId.ReadOnly = true;
            colCategoryId.Width = 125;
            // 
            // colCategoryName
            // 
            colCategoryName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategoryName.HeaderText = "Category Name";
            colCategoryName.MinimumWidth = 6;
            colCategoryName.Name = "colCategoryName";
            colCategoryName.ReadOnly = true;
            // 
            // lblNoResults
            // 
            lblNoResults.Dock = DockStyle.Fill;
            lblNoResults.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoResults.ForeColor = Color.FromArgb(141, 110, 99);
            lblNoResults.Location = new Point(0, 135);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(1011, 465);
            lblNoResults.TabIndex = 4;
            lblNoResults.Text = "No categories found.";
            lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
            lblNoResults.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1011, 600);
            Controls.Add(lblNoResults);
            Controls.Add(dgvCategories);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1000, 600);
            Name = "frmCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";
            WindowState = FormWindowState.Maximized;
            Load += frmCategories_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnAddCategory;
        private Label lblTitle;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn colCategoryId;
        private DataGridViewTextBoxColumn colCategoryName;
        private Button btnInactiveCategories;
        private Label lblNoResults;
        private PictureBox pictureBox1;
    }
}
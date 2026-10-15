namespace CoffeSystem_1UI.Screens
{
    partial class frmInactiveCategories
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInactiveCategories));
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlSearch = new Panel();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvInactiveCategories = new DataGridView();
            lblNoResults = new Label();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInactiveCategories).BeginInit();
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
            pnlHeader.Size = new Size(800, 55);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(222, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inactive Categories";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(pictureBox1);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 55);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(800, 75);
            pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(62, 39, 35);
            txtSearch.Location = new Point(46, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(400, 31);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(62, 39, 35);
            lblSearch.Location = new Point(25, 3);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(160, 28);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search Category";
            // 
            // dgvInactiveCategories
            // 
            dgvInactiveCategories.AllowUserToAddRows = false;
            dgvInactiveCategories.AllowUserToDeleteRows = false;
            dgvInactiveCategories.AllowUserToResizeColumns = false;
            dgvInactiveCategories.AllowUserToResizeRows = false;
            dgvInactiveCategories.BackgroundColor = Color.White;
            dgvInactiveCategories.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInactiveCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInactiveCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInactiveCategories.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInactiveCategories.Dock = DockStyle.Fill;
            dgvInactiveCategories.Location = new Point(0, 130);
            dgvInactiveCategories.Name = "dgvInactiveCategories";
            dgvInactiveCategories.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvInactiveCategories.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvInactiveCategories.RowHeadersVisible = false;
            dgvInactiveCategories.RowHeadersWidth = 51;
            dgvInactiveCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInactiveCategories.Size = new Size(800, 320);
            dgvInactiveCategories.TabIndex = 2;
            dgvInactiveCategories.CellContentClick += dgvInactiveCategories_CellContentClick_1;
            // 
            // lblNoResults
            // 
            lblNoResults.Dock = DockStyle.Fill;
            lblNoResults.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoResults.ForeColor = Color.FromArgb(141, 110, 99);
            lblNoResults.Location = new Point(0, 130);
            lblNoResults.Name = "lblNoResults";
            lblNoResults.Size = new Size(800, 320);
            lblNoResults.TabIndex = 3;
            lblNoResults.Text = "No inactive categories found.";
            lblNoResults.TextAlign = ContentAlignment.MiddleCenter;
            lblNoResults.Click += lblNoResults_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmInactiveCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(800, 450);
            Controls.Add(lblNoResults);
            Controls.Add(dgvInactiveCategories);
            Controls.Add(pnlSearch);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInactiveCategories";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inactive Categories";
            Load += frmInactiveCategories_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInactiveCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridView dgvInactiveCategories;
        private Label lblNoResults;
        private PictureBox pictureBox1;
    }
}
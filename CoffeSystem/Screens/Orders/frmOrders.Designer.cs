namespace CoffeSystem_1UI.Screens
{
    partial class frmOrders
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            pnlHeader = new Panel();
            lblTitle = new Label();
            pnlFilters = new Panel();
            chkAllDates = new CheckBox();
            btnClearFilters = new Button();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            cmbPayment = new ComboBox();
            lblPayment = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            pnlOrders = new Panel();
            dgvOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colOrderDate = new DataGridViewTextBoxColumn();
            colTotalAmount = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colUser = new DataGridViewTextBoxColumn();
            cmsOrder = new ContextMenuStrip(components);
            btnViewDetail = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            cmsOrder.SuspendLayout();
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
            pnlHeader.Size = new Size(1076, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Orders Management";
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(pictureBox1);
            pnlFilters.Controls.Add(chkAllDates);
            pnlFilters.Controls.Add(btnClearFilters);
            pnlFilters.Controls.Add(dtpDate);
            pnlFilters.Controls.Add(lblDate);
            pnlFilters.Controls.Add(cmbPayment);
            pnlFilters.Controls.Add(lblPayment);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 60);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1076, 60);
            pnlFilters.TabIndex = 1;
            // 
            // chkAllDates
            // 
            chkAllDates.AutoSize = true;
            chkAllDates.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAllDates.ForeColor = Color.FromArgb(78, 52, 46);
            chkAllDates.Location = new Point(573, 30);
            chkAllDates.Name = "chkAllDates";
            chkAllDates.Size = new Size(94, 24);
            chkAllDates.TabIndex = 8;
            chkAllDates.Text = "All Dates";
            chkAllDates.UseVisualStyleBackColor = true;
            chkAllDates.CheckedChanged += chkAllDates_CheckedChanged;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(117, 117, 117);
            btnClearFilters.Cursor = Cursors.Hand;
            btnClearFilters.FlatAppearance.BorderSize = 0;
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilters.ForeColor = Color.White;
            btnClearFilters.Location = new Point(953, 26);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(70, 32);
            btnClearFilters.TabIndex = 7;
            btnClearFilters.Text = "Clear";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(705, 23);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(130, 27);
            dtpDate.TabIndex = 6;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDate.ForeColor = Color.FromArgb(78, 52, 46);
            lblDate.Location = new Point(705, -3);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(48, 23);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // cmbPayment
            // 
            cmbPayment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbPayment.ForeColor = Color.FromArgb(60, 60, 60);
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(335, 23);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(180, 31);
            cmbPayment.TabIndex = 4;
            cmbPayment.SelectedIndexChanged += cmbPayment_SelectedIndexChanged;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.BackColor = Color.Transparent;
            lblPayment.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.ForeColor = Color.FromArgb(78, 52, 46);
            lblPayment.Location = new Point(335, 3);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(80, 23);
            lblPayment.TabIndex = 3;
            lblPayment.Text = "Payment";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.White;
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(60, 60, 60);
            txtSearch.Location = new Point(53, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(78, 52, 46);
            lblSearch.Location = new Point(53, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(115, 23);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Order";
            lblSearch.Click += label1_Click;
            // 
            // pnlOrders
            // 
            pnlOrders.Controls.Add(dgvOrders);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(0, 120);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(1076, 735);
            pnlOrders.TabIndex = 2;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AllowUserToResizeColumns = false;
            dgvOrders.AllowUserToResizeRows = false;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colOrderDate, colTotalAmount, colPaymentMethod, colUser });
            dgvOrders.ContextMenuStrip = cmsOrder;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 0);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1076, 735);
            dgvOrders.TabIndex = 0;
            dgvOrders.CellContentClick += dgvOrders_CellContentClick_1;
            dgvOrders.MouseDown += dgvOrders_MouseDown;
            // 
            // colOrderId
            // 
            colOrderId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colOrderId.HeaderText = "Order ID";
            colOrderId.MinimumWidth = 6;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            colOrderId.Width = 120;
            // 
            // colOrderDate
            // 
            colOrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colOrderDate.HeaderText = "Date";
            colOrderDate.MinimumWidth = 6;
            colOrderDate.Name = "colOrderDate";
            colOrderDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            colTotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalAmount.HeaderText = "Total";
            colTotalAmount.MinimumWidth = 6;
            colTotalAmount.Name = "colTotalAmount";
            colTotalAmount.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colPaymentMethod.HeaderText = "Payment";
            colPaymentMethod.MinimumWidth = 6;
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            // 
            // colUser
            // 
            colUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUser.HeaderText = "Cashier";
            colUser.MinimumWidth = 6;
            colUser.Name = "colUser";
            colUser.ReadOnly = true;
            // 
            // cmsOrder
            // 
            cmsOrder.ImageScalingSize = new Size(20, 20);
            cmsOrder.Items.AddRange(new ToolStripItem[] { btnViewDetail });
            cmsOrder.Name = "cmsOrder";
            cmsOrder.Size = new Size(161, 28);
            // 
            // btnViewDetail
            // 
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new Size(160, 24);
            btnViewDetail.Text = "View Details";
            btnViewDetail.Click += btnViewDetail_Click;
            btnViewDetail.DoubleClick += btnViewDetail_DoubleClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1076, 855);
            Controls.Add(pnlOrders);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 800);
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Orders";
            WindowState = FormWindowState.Maximized;
            Load += frmOrders_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            cmsOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlFilters;
        private Panel pnlOrders;
        private DataGridView dgvOrders;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private ComboBox cmbPayment;
        private Label lblPayment;
        private Button btnClearFilters;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colOrderDate;
        private DataGridViewTextBoxColumn colTotalAmount;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colUser;
        private CheckBox chkAllDates;
        private ContextMenuStrip cmsOrder;
        private ToolStripMenuItem btnViewDetail;
        private PictureBox pictureBox1;
    }
}
namespace CoffeSystem_1UI.mainForm
{
    partial class frmMain
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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            btnUsers = new Button();
            btnReports = new Button();
            btnOrders = new Button();
            btnCategories = new Button();
            btnProducts = new Button();
            btnPOS = new Button();
            btnDashboard = new Button();
            lblLogo = new Label();
            pnlContent = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlLowStock = new Panel();
            lblLowStockValue = new Label();
            lblLowStockTitle = new Label();
            pnlOrders = new Panel();
            lblOrdersValue = new Label();
            lblOrdersTitle = new Label();
            pnlProducts = new Panel();
            lblProductsValue = new Label();
            lblProductsTitle = new Label();
            pnlRevenue = new Panel();
            lblRevenueValue = new Label();
            lblRevenueTitle = new Label();
            pnlRecentOrders = new Panel();
            dgvRecentOrders = new DataGridView();
            colOrderId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            label4 = new Label();
            lblRecentOrdersTitle = new Label();
            pnlSalesChar = new Panel();
            pnlSalesChart = new Panel();
            label1 = new Label();
            lblSalesChartTitle = new Label();
            pnlHeader = new Panel();
            lblUser = new Label();
            lblPageTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlProducts.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).BeginInit();
            pnlSalesChart.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(78, 52, 46);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Controls.Add(btnUsers);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(btnOrders);
            pnlSidebar.Controls.Add(btnCategories);
            pnlSidebar.Controls.Add(btnProducts);
            pnlSidebar.Controls.Add(btnPOS);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(292, 942);
            pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(78, 52, 46);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(5, 604);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(220, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "🚪  Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSettings.BackColor = Color.FromArgb(78, 52, 46);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(5, 455);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(220, 50);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "⚙️  Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnUsers
            // 
            btnUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnUsers.BackColor = Color.FromArgb(78, 52, 46);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.White;
            btnUsers.Location = new Point(5, 400);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(220, 50);
            btnUsers.TabIndex = 7;
            btnUsers.Text = "👤  Users";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnReports
            // 
            btnReports.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnReports.BackColor = Color.FromArgb(78, 52, 46);
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Location = new Point(5, 345);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(220, 50);
            btnReports.TabIndex = 6;
            btnReports.Text = "📊  Reports";
            btnReports.UseVisualStyleBackColor = false;
            btnReports.Click += btnReports_Click;
            // 
            // btnOrders
            // 
            btnOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOrders.BackColor = Color.FromArgb(78, 52, 46);
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(5, 290);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(220, 50);
            btnOrders.TabIndex = 5;
            btnOrders.Text = "\U0001f9fe  Orders";
            btnOrders.UseVisualStyleBackColor = false;
            btnOrders.Click += btnOrders_Click;
            // 
            // btnCategories
            // 
            btnCategories.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCategories.BackColor = Color.FromArgb(78, 52, 46);
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCategories.ForeColor = Color.White;
            btnCategories.Location = new Point(5, 235);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(220, 50);
            btnCategories.TabIndex = 4;
            btnCategories.Text = "🗂️  Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnProducts
            // 
            btnProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnProducts.BackColor = Color.FromArgb(78, 52, 46);
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(5, 180);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(220, 50);
            btnProducts.TabIndex = 3;
            btnProducts.Text = "📦  Products";
            btnProducts.UseVisualStyleBackColor = false;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnPOS
            // 
            btnPOS.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPOS.BackColor = Color.FromArgb(78, 52, 46);
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPOS.ForeColor = Color.White;
            btnPOS.Location = new Point(5, 125);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(220, 50);
            btnPOS.TabIndex = 2;
            btnPOS.Text = "\U0001f6d2  POS";
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDashboard.BackColor = Color.FromArgb(78, 52, 46);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(5, 70);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 50);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "🏠  Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(5, 15);
            lblLogo.Name = "lblLogo";
            lblLogo.Padding = new Padding(5, 15, 0, 0);
            lblLogo.Size = new Size(282, 53);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "☕ COFFEE SYSTEM";
            lblLogo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContent.BackColor = Color.WhiteSmoke;
            pnlContent.Controls.Add(tableLayoutPanel1);
            pnlContent.Controls.Add(pnlRecentOrders);
            pnlContent.Controls.Add(pnlSalesChar);
            pnlContent.Controls.Add(pnlSalesChart);
            pnlContent.Controls.Add(pnlHeader);
            pnlContent.Location = new Point(292, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1449, 939);
            pnlContent.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlLowStock, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlOrders, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlProducts, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlRevenue, 0, 0);
            tableLayoutPanel1.Location = new Point(30, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1389, 117);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(lblLowStockValue);
            pnlLowStock.Controls.Add(lblLowStockTitle);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(1044, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(342, 111);
            pnlLowStock.TabIndex = 6;
            pnlLowStock.Paint += pnlLowStock_Paint;
            // 
            // lblLowStockValue
            // 
            lblLowStockValue.AutoSize = true;
            lblLowStockValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockValue.ForeColor = Color.FromArgb(78, 52, 46);
            lblLowStockValue.Location = new Point(15, 50);
            lblLowStockValue.Name = "lblLowStockValue";
            lblLowStockValue.Size = new Size(35, 41);
            lblLowStockValue.TabIndex = 3;
            lblLowStockValue.Text = "0";
            // 
            // lblLowStockTitle
            // 
            lblLowStockTitle.AutoSize = true;
            lblLowStockTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockTitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblLowStockTitle.Location = new Point(15, 15);
            lblLowStockTitle.Name = "lblLowStockTitle";
            lblLowStockTitle.Size = new Size(93, 23);
            lblLowStockTitle.TabIndex = 2;
            lblLowStockTitle.Text = "Low Stock";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrdersValue);
            pnlOrders.Controls.Add(lblOrdersTitle);
            pnlOrders.Dock = DockStyle.Fill;
            pnlOrders.Location = new Point(350, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(341, 111);
            pnlOrders.TabIndex = 4;
            // 
            // lblOrdersValue
            // 
            lblOrdersValue.AutoSize = true;
            lblOrdersValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrdersValue.ForeColor = Color.FromArgb(78, 52, 46);
            lblOrdersValue.Location = new Point(15, 50);
            lblOrdersValue.Name = "lblOrdersValue";
            lblOrdersValue.Size = new Size(35, 41);
            lblOrdersValue.TabIndex = 3;
            lblOrdersValue.Text = "0";
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrdersTitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblOrdersTitle.Location = new Point(15, 15);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(127, 23);
            lblOrdersTitle.TabIndex = 2;
            lblOrdersTitle.Text = "Today's Orders";
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.White;
            pnlProducts.Controls.Add(lblProductsValue);
            pnlProducts.Controls.Add(lblProductsTitle);
            pnlProducts.Dock = DockStyle.Fill;
            pnlProducts.Location = new Point(697, 3);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(341, 111);
            pnlProducts.TabIndex = 5;
            // 
            // lblProductsValue
            // 
            lblProductsValue.AutoSize = true;
            lblProductsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsValue.ForeColor = Color.FromArgb(78, 52, 46);
            lblProductsValue.Location = new Point(15, 50);
            lblProductsValue.Name = "lblProductsValue";
            lblProductsValue.Size = new Size(35, 41);
            lblProductsValue.TabIndex = 3;
            lblProductsValue.Text = "0";
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsTitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblProductsTitle.Location = new Point(15, 15);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(124, 23);
            lblProductsTitle.TabIndex = 2;
            lblProductsTitle.Text = "Total Products";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueValue);
            pnlRevenue.Controls.Add(lblRevenueTitle);
            pnlRevenue.Dock = DockStyle.Fill;
            pnlRevenue.Location = new Point(3, 3);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(341, 111);
            pnlRevenue.TabIndex = 1;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueValue.ForeColor = Color.FromArgb(78, 52, 46);
            lblRevenueValue.Location = new Point(15, 50);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(141, 41);
            lblRevenueValue.TabIndex = 3;
            lblRevenueValue.Text = "0.000 DT";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRevenueTitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblRevenueTitle.Location = new Point(15, 15);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(140, 23);
            lblRevenueTitle.TabIndex = 2;
            lblRevenueTitle.Text = "Today's Revenue";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlRecentOrders.BackColor = Color.White;
            pnlRecentOrders.Controls.Add(dgvRecentOrders);
            pnlRecentOrders.Controls.Add(label4);
            pnlRecentOrders.Controls.Add(lblRecentOrdersTitle);
            pnlRecentOrders.Location = new Point(30, 660);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(1389, 270);
            pnlRecentOrders.TabIndex = 7;
            // 
            // dgvRecentOrders
            // 
            dgvRecentOrders.AllowUserToAddRows = false;
            dgvRecentOrders.AllowUserToDeleteRows = false;
            dgvRecentOrders.AllowUserToResizeColumns = false;
            dgvRecentOrders.AllowUserToResizeRows = false;
            dgvRecentOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentOrders.BackgroundColor = Color.White;
            dgvRecentOrders.BorderStyle = BorderStyle.None;
            dgvRecentOrders.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(78, 52, 46);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentOrders.Columns.AddRange(new DataGridViewColumn[] { colOrderId, colDate, colTotal, colStatus, colPayment });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(51, 51, 51);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(215, 204, 200);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(78, 52, 46);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRecentOrders.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentOrders.GridColor = Color.FromArgb(224, 224, 224);
            dgvRecentOrders.Location = new Point(20, 55);
            dgvRecentOrders.MultiSelect = false;
            dgvRecentOrders.Name = "dgvRecentOrders";
            dgvRecentOrders.ReadOnly = true;
            dgvRecentOrders.RowHeadersVisible = false;
            dgvRecentOrders.RowHeadersWidth = 51;
            dgvRecentOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentOrders.Size = new Size(1349, 194);
            dgvRecentOrders.TabIndex = 4;
            // 
            // colOrderId
            // 
            colOrderId.HeaderText = "Order ID";
            colOrderId.MinimumWidth = 6;
            colOrderId.Name = "colOrderId";
            colOrderId.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colPayment
            // 
            colPayment.HeaderText = "Payment";
            colPayment.MinimumWidth = 6;
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(78, 52, 46);
            label4.Location = new Point(15, 50);
            label4.Name = "label4";
            label4.Size = new Size(35, 41);
            label4.TabIndex = 3;
            label4.Text = "0";
            // 
            // lblRecentOrdersTitle
            // 
            lblRecentOrdersTitle.AutoSize = true;
            lblRecentOrdersTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentOrdersTitle.ForeColor = Color.FromArgb(78, 52, 46);
            lblRecentOrdersTitle.Location = new Point(20, 15);
            lblRecentOrdersTitle.Name = "lblRecentOrdersTitle";
            lblRecentOrdersTitle.Size = new Size(163, 31);
            lblRecentOrdersTitle.TabIndex = 2;
            lblRecentOrdersTitle.Text = "Recent Orders";
            // 
            // pnlSalesChar
            // 
            pnlSalesChar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSalesChar.BackColor = Color.White;
            pnlSalesChar.Location = new Point(30, 224);
            pnlSalesChar.Name = "pnlSalesChar";
            pnlSalesChar.Size = new Size(1389, 430);
            pnlSalesChar.TabIndex = 7;
            // 
            // pnlSalesChart
            // 
            pnlSalesChart.BackColor = Color.White;
            pnlSalesChart.Controls.Add(label1);
            pnlSalesChart.Controls.Add(lblSalesChartTitle);
            pnlSalesChart.Location = new Point(30, 250);
            pnlSalesChart.Name = "pnlSalesChart";
            pnlSalesChart.Size = new Size(780, 300);
            pnlSalesChart.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(78, 52, 46);
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(35, 41);
            label1.TabIndex = 3;
            label1.Text = "0";
            // 
            // lblSalesChartTitle
            // 
            lblSalesChartTitle.AutoSize = true;
            lblSalesChartTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesChartTitle.ForeColor = Color.FromArgb(102, 102, 102);
            lblSalesChartTitle.Location = new Point(15, 15);
            lblSalesChartTitle.Name = "lblSalesChartTitle";
            lblSalesChartTitle.Size = new Size(131, 23);
            lblSalesChartTitle.TabIndex = 2;
            lblSalesChartTitle.Text = "Sales Overview";
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblUser);
            pnlHeader.Controls.Add(lblPageTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1449, 70);
            pnlHeader.TabIndex = 0;
            pnlHeader.Paint += pnlHeader_Paint;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(78, 52, 46);
            lblUser.Location = new Point(1293, 25);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(95, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "👤 Admin";
            lblUser.Click += lblUser_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(78, 52, 46);
            lblPageTitle.Location = new Point(25, 20);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(193, 46);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1741, 942);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1400, 700);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee System";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlContent.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentOrders).EndInit();
            pnlSalesChart.ResumeLayout(false);
            pnlSalesChart.PerformLayout();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLogo;
        private Button btnDashboard;
        private Button btnPOS;
        private Button btnProducts;
        private Button btnReports;
        private Button btnOrders;
        private Button btnCategories;
        private Button btnUsers;
        private Button btnSettings;
        private Panel pnlContent;
        private Panel pnlHeader;
        private Label lblPageTitle;
        private Button btnLogout;
        private Label lblUser;
        private Panel pnlRevenue;
        private Label lblRevenueValue;
        private Label lblRevenueTitle;
        private Panel pnlProducts;
        private Label lblProductsValue;
        private Label lblProductsTitle;
        private Panel pnlOrders;
        private Label lblOrdersValue;
        private Label lblOrdersTitle;
        private Panel pnlLowStock;
        private Label lblLowStockValue;
        private Label lblLowStockTitle;
        private Panel pnlSalesChart;
        private Label label1;
        private Label lblSalesChartTitle;
        private Panel pnlRecentOrders;
        private Label label4;
        private Label lblRecentOrdersTitle;
        private Panel pnlSalesChar;
        private DataGridView dgvRecentOrders;
        private DataGridViewTextBoxColumn colOrderId;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTotal;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPayment;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
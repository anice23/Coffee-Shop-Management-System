namespace CoffeSystem_1UI.Screens.Reports
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            pnlHeader = new Panel();
            lbSubtitle = new Label();
            lbTitle = new Label();
            pnlFilters = new Panel();
            btnExportReport = new Button();
            btnResetFilters = new Button();
            btnGenerateReport = new Button();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            cmbPeriod = new ComboBox();
            lblPeriod = new Label();
            pnlContent = new Panel();
            pnlProductBestSelling = new Panel();
            dgvBestSellingProducts = new DataGridView();
            lblProductSalesTitle = new Label();
            pnlKpiCards = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlBestProductCard = new Panel();
            lblBestProductQuantity = new Label();
            lblBestSellingProduct = new Label();
            lblBestProductTitle = new Label();
            pnlAverageCard = new Panel();
            lblAverageOrderValue = new Label();
            lblAverageTitle = new Label();
            pnlRevenueCard = new Panel();
            lblTotalRevenue = new Label();
            lblRevenueTitle = new Label();
            pnlOrdersCard = new Panel();
            lblTotalOrders = new Label();
            lblOrdersTitle = new Label();
            pnlCharts = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlPaymentChart = new Panel();
            lblPaymentChartTitle = new Label();
            pnlSalesChart = new Panel();
            lblSalesChartTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlProductBestSelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingProducts).BeginInit();
            pnlKpiCards.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlBestProductCard.SuspendLayout();
            pnlAverageCard.SuspendLayout();
            pnlRevenueCard.SuspendLayout();
            pnlOrdersCard.SuspendLayout();
            pnlCharts.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlPaymentChart.SuspendLayout();
            pnlSalesChart.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.AutoSize = true;
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lbSubtitle);
            pnlHeader.Controls.Add(lbTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1619, 66);
            pnlHeader.TabIndex = 0;
            // 
            // lbSubtitle
            // 
            lbSubtitle.AutoSize = true;
            lbSubtitle.BackColor = Color.Transparent;
            lbSubtitle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubtitle.ForeColor = Color.White;
            lbSubtitle.Location = new Point(28, 46);
            lbSubtitle.Name = "lbSubtitle";
            lbSubtitle.Size = new Size(220, 20);
            lbSubtitle.TabIndex = 1;
            lbSubtitle.Text = "Coffee System · Sales & Analytics";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(12, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(112, 37);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "Reports";
            // 
            // pnlFilters
            // 
            pnlFilters.AutoSize = true;
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(btnExportReport);
            pnlFilters.Controls.Add(btnResetFilters);
            pnlFilters.Controls.Add(btnGenerateReport);
            pnlFilters.Controls.Add(lblToDate);
            pnlFilters.Controls.Add(dtpToDate);
            pnlFilters.Controls.Add(lblFromDate);
            pnlFilters.Controls.Add(dtpFromDate);
            pnlFilters.Controls.Add(cmbPeriod);
            pnlFilters.Controls.Add(lblPeriod);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.ForeColor = Color.Black;
            pnlFilters.Location = new Point(0, 66);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1619, 70);
            pnlFilters.TabIndex = 1;
            // 
            // btnExportReport
            // 
            btnExportReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportReport.BackColor = Color.FromArgb(62, 39, 35);
            btnExportReport.FlatAppearance.BorderSize = 0;
            btnExportReport.FlatStyle = FlatStyle.Flat;
            btnExportReport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportReport.ForeColor = Color.White;
            btnExportReport.Location = new Point(1479, 26);
            btnExportReport.Name = "btnExportReport";
            btnExportReport.Size = new Size(125, 38);
            btnExportReport.TabIndex = 8;
            btnExportReport.Text = "Export CSV";
            btnExportReport.UseVisualStyleBackColor = false;
            btnExportReport.Click += btnExportReport_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnResetFilters.BackColor = Color.White;
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetFilters.ForeColor = Color.FromArgb(62, 39, 35);
            btnResetFilters.Location = new Point(1277, 25);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(196, 38);
            btnResetFilters.TabIndex = 7;
            btnResetFilters.Text = "Reset";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerateReport.BackColor = Color.FromArgb(111, 78, 55);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = FlatStyle.Flat;
            btnGenerateReport.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = Color.White;
            btnGenerateReport.Location = new Point(1075, 25);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(196, 38);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click_1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToDate.Location = new Point(355, 12);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(27, 23);
            lblToDate.TabIndex = 5;
            lblToDate.Text = "To";
            // 
            // dtpToDate
            // 
            dtpToDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpToDate.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            dtpToDate.Format = DateTimePickerFormat.Short;
            dtpToDate.Location = new Point(355, 38);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(130, 29);
            dtpToDate.TabIndex = 4;
            dtpToDate.ValueChanged += dtpToDate_ValueChanged;
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromDate.Location = new Point(205, 14);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(50, 23);
            lblFromDate.TabIndex = 3;
            lblFromDate.Text = "From";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFromDate.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            dtpFromDate.Format = DateTimePickerFormat.Short;
            dtpFromDate.Location = new Point(205, 38);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(130, 29);
            dtpFromDate.TabIndex = 2;
            dtpFromDate.ValueChanged += dtpFromDate_ValueChanged;
            // 
            // cmbPeriod
            // 
            cmbPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriod.FormattingEnabled = true;
            cmbPeriod.Location = new Point(12, 39);
            cmbPeriod.Name = "cmbPeriod";
            cmbPeriod.Size = new Size(160, 28);
            cmbPeriod.TabIndex = 1;
            cmbPeriod.SelectedIndexChanged += cmbPeriod_SelectedIndexChanged_1;
            // 
            // lblPeriod
            // 
            lblPeriod.AutoSize = true;
            lblPeriod.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPeriod.ForeColor = Color.FromArgb(62, 39, 35);
            lblPeriod.Location = new Point(12, 14);
            lblPeriod.Name = "lblPeriod";
            lblPeriod.Size = new Size(129, 25);
            lblPeriod.TabIndex = 0;
            lblPeriod.Text = "Report Period";
            // 
            // pnlContent
            // 
            pnlContent.Controls.Add(pnlProductBestSelling);
            pnlContent.Controls.Add(pnlKpiCards);
            pnlContent.Controls.Add(pnlCharts);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 136);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1619, 791);
            pnlContent.TabIndex = 2;
            // 
            // pnlProductBestSelling
            // 
            pnlProductBestSelling.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlProductBestSelling.Controls.Add(dgvBestSellingProducts);
            pnlProductBestSelling.Controls.Add(lblProductSalesTitle);
            pnlProductBestSelling.Location = new Point(16, 506);
            pnlProductBestSelling.Name = "pnlProductBestSelling";
            pnlProductBestSelling.Size = new Size(1600, 233);
            pnlProductBestSelling.TabIndex = 10;
            // 
            // dgvBestSellingProducts
            // 
            dgvBestSellingProducts.AllowUserToAddRows = false;
            dgvBestSellingProducts.AllowUserToDeleteRows = false;
            dgvBestSellingProducts.AllowUserToResizeColumns = false;
            dgvBestSellingProducts.AllowUserToResizeRows = false;
            dgvBestSellingProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBestSellingProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBestSellingProducts.BackgroundColor = Color.White;
            dgvBestSellingProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBestSellingProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBestSellingProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBestSellingProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBestSellingProducts.Location = new Point(15, 47);
            dgvBestSellingProducts.Margin = new Padding(0);
            dgvBestSellingProducts.Name = "dgvBestSellingProducts";
            dgvBestSellingProducts.ReadOnly = true;
            dgvBestSellingProducts.RowHeadersVisible = false;
            dgvBestSellingProducts.RowHeadersWidth = 51;
            dgvBestSellingProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBestSellingProducts.Size = new Size(1573, 176);
            dgvBestSellingProducts.TabIndex = 4;
            // 
            // lblProductSalesTitle
            // 
            lblProductSalesTitle.AutoSize = true;
            lblProductSalesTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblProductSalesTitle.ForeColor = Color.FromArgb(62, 39, 35);
            lblProductSalesTitle.Location = new Point(3, 12);
            lblProductSalesTitle.Name = "lblProductSalesTitle";
            lblProductSalesTitle.Size = new Size(170, 23);
            lblProductSalesTitle.TabIndex = 0;
            lblProductSalesTitle.Text = "Best-Selling Products";
            // 
            // pnlKpiCards
            // 
            pnlKpiCards.Controls.Add(tableLayoutPanel1);
            pnlKpiCards.Dock = DockStyle.Top;
            pnlKpiCards.Location = new Point(0, 0);
            pnlKpiCards.Name = "pnlKpiCards";
            pnlKpiCards.Size = new Size(1619, 145);
            pnlKpiCards.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(pnlBestProductCard, 3, 0);
            tableLayoutPanel1.Controls.Add(pnlAverageCard, 2, 0);
            tableLayoutPanel1.Controls.Add(pnlRevenueCard, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlOrdersCard, 1, 0);
            tableLayoutPanel1.Location = new Point(10, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1606, 133);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // pnlBestProductCard
            // 
            pnlBestProductCard.AutoSize = true;
            pnlBestProductCard.BackColor = Color.White;
            pnlBestProductCard.Controls.Add(lblBestProductQuantity);
            pnlBestProductCard.Controls.Add(lblBestSellingProduct);
            pnlBestProductCard.Controls.Add(lblBestProductTitle);
            pnlBestProductCard.Dock = DockStyle.Fill;
            pnlBestProductCard.Location = new Point(1206, 3);
            pnlBestProductCard.Name = "pnlBestProductCard";
            pnlBestProductCard.Size = new Size(397, 127);
            pnlBestProductCard.TabIndex = 4;
            // 
            // lblBestProductQuantity
            // 
            lblBestProductQuantity.AutoSize = true;
            lblBestProductQuantity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBestProductQuantity.ForeColor = Color.FromArgb(111, 78, 55);
            lblBestProductQuantity.Location = new Point(15, 75);
            lblBestProductQuantity.Name = "lblBestProductQuantity";
            lblBestProductQuantity.Size = new Size(97, 23);
            lblBestProductQuantity.TabIndex = 2;
            lblBestProductQuantity.Text = "0 units sold";
            // 
            // lblBestSellingProduct
            // 
            lblBestSellingProduct.AutoSize = true;
            lblBestSellingProduct.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBestSellingProduct.ForeColor = Color.FromArgb(62, 39, 35);
            lblBestSellingProduct.Location = new Point(15, 45);
            lblBestSellingProduct.Name = "lblBestSellingProduct";
            lblBestSellingProduct.Size = new Size(45, 25);
            lblBestSellingProduct.TabIndex = 1;
            lblBestSellingProduct.Text = "N/A";
            // 
            // lblBestProductTitle
            // 
            lblBestProductTitle.AutoSize = true;
            lblBestProductTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBestProductTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblBestProductTitle.Location = new Point(15, 15);
            lblBestProductTitle.Name = "lblBestProductTitle";
            lblBestProductTitle.Size = new Size(201, 23);
            lblBestProductTitle.TabIndex = 0;
            lblBestProductTitle.Text = "BEST-SELLING PRODUCT";
            // 
            // pnlAverageCard
            // 
            pnlAverageCard.AutoSize = true;
            pnlAverageCard.BackColor = Color.White;
            pnlAverageCard.Controls.Add(lblAverageOrderValue);
            pnlAverageCard.Controls.Add(lblAverageTitle);
            pnlAverageCard.Dock = DockStyle.Fill;
            pnlAverageCard.Location = new Point(805, 3);
            pnlAverageCard.Name = "pnlAverageCard";
            pnlAverageCard.Size = new Size(395, 127);
            pnlAverageCard.TabIndex = 3;
            // 
            // lblAverageOrderValue
            // 
            lblAverageOrderValue.AutoSize = true;
            lblAverageOrderValue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAverageOrderValue.ForeColor = Color.FromArgb(62, 39, 35);
            lblAverageOrderValue.Location = new Point(15, 45);
            lblAverageOrderValue.Name = "lblAverageOrderValue";
            lblAverageOrderValue.Size = new Size(83, 25);
            lblAverageOrderValue.TabIndex = 1;
            lblAverageOrderValue.Text = "0.000 DT";
            // 
            // lblAverageTitle
            // 
            lblAverageTitle.AutoSize = true;
            lblAverageTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblAverageTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblAverageTitle.Location = new Point(15, 15);
            lblAverageTitle.Name = "lblAverageTitle";
            lblAverageTitle.Size = new Size(199, 23);
            lblAverageTitle.TabIndex = 0;
            lblAverageTitle.Text = "AVERAGE ORDER VALUE";
            // 
            // pnlRevenueCard
            // 
            pnlRevenueCard.AutoSize = true;
            pnlRevenueCard.BackColor = Color.White;
            pnlRevenueCard.Controls.Add(lblTotalRevenue);
            pnlRevenueCard.Controls.Add(lblRevenueTitle);
            pnlRevenueCard.Dock = DockStyle.Fill;
            pnlRevenueCard.Location = new Point(3, 3);
            pnlRevenueCard.Name = "pnlRevenueCard";
            pnlRevenueCard.Size = new Size(395, 127);
            pnlRevenueCard.TabIndex = 0;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRevenue.ForeColor = Color.FromArgb(62, 39, 35);
            lblTotalRevenue.Location = new Point(15, 45);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(83, 25);
            lblTotalRevenue.TabIndex = 1;
            lblTotalRevenue.Text = "0.000 DT";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblRevenueTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblRevenueTitle.Location = new Point(15, 15);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(136, 23);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "TOTAL REVENUE";
            // 
            // pnlOrdersCard
            // 
            pnlOrdersCard.AutoSize = true;
            pnlOrdersCard.BackColor = Color.White;
            pnlOrdersCard.Controls.Add(lblTotalOrders);
            pnlOrdersCard.Controls.Add(lblOrdersTitle);
            pnlOrdersCard.Dock = DockStyle.Fill;
            pnlOrdersCard.Location = new Point(404, 3);
            pnlOrdersCard.Name = "pnlOrdersCard";
            pnlOrdersCard.Size = new Size(395, 127);
            pnlOrdersCard.TabIndex = 2;
            // 
            // lblTotalOrders
            // 
            lblTotalOrders.AutoSize = true;
            lblTotalOrders.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalOrders.ForeColor = Color.FromArgb(62, 39, 35);
            lblTotalOrders.Location = new Point(15, 45);
            lblTotalOrders.Name = "lblTotalOrders";
            lblTotalOrders.Size = new Size(22, 25);
            lblTotalOrders.TabIndex = 1;
            lblTotalOrders.Text = "0";
            // 
            // lblOrdersTitle
            // 
            lblOrdersTitle.AutoSize = true;
            lblOrdersTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblOrdersTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblOrdersTitle.Location = new Point(15, 15);
            lblOrdersTitle.Name = "lblOrdersTitle";
            lblOrdersTitle.Size = new Size(127, 23);
            lblOrdersTitle.TabIndex = 0;
            lblOrdersTitle.Text = "TOTAL ORDERS";
            // 
            // pnlCharts
            // 
            pnlCharts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCharts.Controls.Add(tableLayoutPanel2);
            pnlCharts.Location = new Point(16, 162);
            pnlCharts.Margin = new Padding(0);
            pnlCharts.Name = "pnlCharts";
            pnlCharts.Size = new Size(1600, 625);
            pnlCharts.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pnlPaymentChart, 1, 0);
            tableLayoutPanel2.Controls.Add(pnlSalesChart, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1592, 306);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pnlPaymentChart
            // 
            pnlPaymentChart.AutoSize = true;
            pnlPaymentChart.BackColor = Color.White;
            pnlPaymentChart.Controls.Add(lblPaymentChartTitle);
            pnlPaymentChart.Dock = DockStyle.Fill;
            pnlPaymentChart.Location = new Point(796, 0);
            pnlPaymentChart.Margin = new Padding(0);
            pnlPaymentChart.Name = "pnlPaymentChart";
            pnlPaymentChart.Size = new Size(796, 306);
            pnlPaymentChart.TabIndex = 1;
            // 
            // lblPaymentChartTitle
            // 
            lblPaymentChartTitle.AutoSize = true;
            lblPaymentChartTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblPaymentChartTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblPaymentChartTitle.Location = new Point(15, 12);
            lblPaymentChartTitle.Name = "lblPaymentChartTitle";
            lblPaymentChartTitle.Size = new Size(151, 23);
            lblPaymentChartTitle.TabIndex = 3;
            lblPaymentChartTitle.Text = "Payment Methods";
            // 
            // pnlSalesChart
            // 
            pnlSalesChart.AutoSize = true;
            pnlSalesChart.BackColor = Color.White;
            pnlSalesChart.Controls.Add(lblSalesChartTitle);
            pnlSalesChart.Dock = DockStyle.Fill;
            pnlSalesChart.Location = new Point(0, 0);
            pnlSalesChart.Margin = new Padding(0);
            pnlSalesChart.Name = "pnlSalesChart";
            pnlSalesChart.Size = new Size(796, 306);
            pnlSalesChart.TabIndex = 0;
            // 
            // lblSalesChartTitle
            // 
            lblSalesChartTitle.AutoSize = true;
            lblSalesChartTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSalesChartTitle.ForeColor = Color.FromArgb(111, 78, 55);
            lblSalesChartTitle.Location = new Point(15, 12);
            lblSalesChartTitle.Name = "lblSalesChartTitle";
            lblSalesChartTitle.Size = new Size(96, 23);
            lblSalesChartTitle.TabIndex = 2;
            lblSalesChartTitle.Text = "Sales Trend";
            // 
            // frmReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(1619, 927);
            Controls.Add(pnlContent);
            Controls.Add(pnlFilters);
            Controls.Add(pnlHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1520, 750);
            Name = "frmReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            WindowState = FormWindowState.Maximized;
            Load += frmReports_Load;
            Shown += frmReports_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlProductBestSelling.ResumeLayout(false);
            pnlProductBestSelling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellingProducts).EndInit();
            pnlKpiCards.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlBestProductCard.ResumeLayout(false);
            pnlBestProductCard.PerformLayout();
            pnlAverageCard.ResumeLayout(false);
            pnlAverageCard.PerformLayout();
            pnlRevenueCard.ResumeLayout(false);
            pnlRevenueCard.PerformLayout();
            pnlOrdersCard.ResumeLayout(false);
            pnlOrdersCard.PerformLayout();
            pnlCharts.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlPaymentChart.ResumeLayout(false);
            pnlPaymentChart.PerformLayout();
            pnlSalesChart.ResumeLayout(false);
            pnlSalesChart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lbSubtitle;
        private Label lbTitle;
        private Panel pnlFilters;
        private Panel pnlContent;
        private ComboBox cmbPeriod;
        private Label lblPeriod;
        private Label lblToDate;
        private DateTimePicker dtpToDate;
        private Label lblFromDate;
        private DateTimePicker dtpFromDate;
        private Button btnGenerateReport;
        private Button btnResetFilters;
        private Panel pnlKpiCards;
        private Panel pnlOrdersCard;
        private Label lblTotalOrders;
        private Label lblOrdersTitle;
        private Panel pnlRevenueCard;
        private Label lblTotalRevenue;
        private Label lblRevenueTitle;
        private Panel pnlBestProductCard;
        private Label lblBestSellingProduct;
        private Label lblBestProductTitle;
        private Panel pnlAverageCard;
        private Label lblAverageOrderValue;
        private Label lblAverageTitle;
        private Panel pnlCharts;
        private Panel pnlSalesChart;
        private Label lblSalesChartTitle;
        private Label lblBestProductQuantity;
        private Panel pnlPaymentChart;
        private Label lblPaymentChartTitle;
        private Button btnExportReport;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel pnlProductBestSelling;
        private DataGridView dgvBestSellingProducts;
        private Label lblProductSalesTitle;
    }
}
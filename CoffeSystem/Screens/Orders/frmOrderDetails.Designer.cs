namespace CoffeSystem_1UI.Screens
{
    partial class frmOrderDetails
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
            pnlOrderInfo = new Panel();
            lblCashier = new Label();
            lblPayment = new Label();
            lblOrderDate = new Label();
            lblOrderId = new Label();
            lblTotal = new Label();
            pnlItems = new Panel();
            dgvItems = new DataGridView();
            colProduct = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colItemTotal = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            pnlFooter = new Panel();
            btnPrint = new Button();
            pnlHeader.SuspendLayout();
            pnlOrderInfo.SuspendLayout();
            pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(830, 70);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(78, 52, 46);
            lblTitle.Location = new Point(20, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(177, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Order Details";
            // 
            // pnlOrderInfo
            // 
            pnlOrderInfo.Controls.Add(lblCashier);
            pnlOrderInfo.Controls.Add(lblPayment);
            pnlOrderInfo.Controls.Add(lblOrderDate);
            pnlOrderInfo.Controls.Add(lblOrderId);
            pnlOrderInfo.Dock = DockStyle.Top;
            pnlOrderInfo.Location = new Point(0, 70);
            pnlOrderInfo.Name = "pnlOrderInfo";
            pnlOrderInfo.Size = new Size(830, 90);
            pnlOrderInfo.TabIndex = 2;
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.ForeColor = Color.FromArgb(78, 52, 46);
            lblCashier.Location = new Point(20, 50);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(80, 25);
            lblCashier.TabIndex = 4;
            lblCashier.Text = "Cashier:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.ForeColor = Color.FromArgb(78, 52, 46);
            lblPayment.Location = new Point(524, 15);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(92, 25);
            lblPayment.TabIndex = 3;
            lblPayment.Text = "Payment:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.FromArgb(78, 52, 46);
            lblOrderDate.Location = new Point(220, 15);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(62, 25);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = " Date:";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderId.ForeColor = Color.FromArgb(78, 52, 46);
            lblOrderId.Location = new Point(20, 15);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(90, 25);
            lblOrderId.TabIndex = 1;
            lblOrderId.Text = "Order ID:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(78, 52, 46);
            lblTotal.Location = new Point(69, 17);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(137, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total: 0.000 DT";
            // 
            // pnlItems
            // 
            pnlItems.Controls.Add(dgvItems);
            pnlItems.Dock = DockStyle.Fill;
            pnlItems.Location = new Point(0, 160);
            pnlItems.Name = "pnlItems";
            pnlItems.Padding = new Padding(20);
            pnlItems.Size = new Size(830, 463);
            pnlItems.TabIndex = 3;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToOrderColumns = true;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { colProduct, colQuantity, colUnitPrice, colItemTotal });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(20, 20);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(790, 423);
            dgvItems.TabIndex = 0;
            // 
            // colProduct
            // 
            colProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProduct.HeaderText = "Product";
            colProduct.MinimumWidth = 6;
            colProduct.Name = "colProduct";
            colProduct.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            colQuantity.Width = 125;
            // 
            // colUnitPrice
            // 
            colUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colItemTotal
            // 
            colItemTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colItemTotal.HeaderText = "Total";
            colItemTotal.MinimumWidth = 6;
            colItemTotal.Name = "colItemTotal";
            colItemTotal.ReadOnly = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(78, 52, 46);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(701, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 35);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(btnPrint);
            pnlFooter.Controls.Add(lblTotal);
            pnlFooter.Controls.Add(btnClose);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 563);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(830, 60);
            pnlFooter.TabIndex = 5;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(25, 118, 210);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(581, 13);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(90, 35);
            btnPrint.TabIndex = 6;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(830, 623);
            Controls.Add(pnlFooter);
            Controls.Add(pnlItems);
            Controls.Add(pnlOrderInfo);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Details";
            Load += frmOrderDetails_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlOrderInfo.ResumeLayout(false);
            pnlOrderInfo.PerformLayout();
            pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlOrderInfo;
        private Label lblCashier;
        private Label lblPayment;
        private Label lblOrderDate;
        private Label lblOrderId;
        private Panel pnlItems;
        private DataGridView dgvItems;
        private DataGridViewTextBoxColumn colProduct;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colItemTotal;
        private Label lblTotal;
        private Button btnClose;
        private Panel pnlFooter;
        private Button btnPrint;
    }
}
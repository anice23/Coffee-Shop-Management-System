namespace CoffeSystem_1UI.Screens
{
    partial class frmReceipt
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
            pnlReceipt = new Panel();
            btnPrint = new Button();
            lblReceiptTotal = new Label();
            lblReceiptTotalTitle = new Label();
            dgvReceiptItems = new DataGridView();
            colReceiptProduct = new DataGridViewTextBoxColumn();
            colReceiptQuantity = new DataGridViewTextBoxColumn();
            colReceiptUnitPrice = new DataGridViewTextBoxColumn();
            colReceiptTotal = new DataGridViewTextBoxColumn();
            lblPaymentMethod = new Label();
            lblOrderDate = new Label();
            lblOrderId = new Label();
            lblReceiptTitle = new Label();
            lblShopName = new Label();
            lblCashier = new Label();
            pnlReceipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptItems).BeginInit();
            SuspendLayout();
            // 
            // pnlReceipt
            // 
            pnlReceipt.Controls.Add(lblCashier);
            pnlReceipt.Controls.Add(btnPrint);
            pnlReceipt.Controls.Add(lblReceiptTotal);
            pnlReceipt.Controls.Add(lblReceiptTotalTitle);
            pnlReceipt.Controls.Add(dgvReceiptItems);
            pnlReceipt.Controls.Add(lblPaymentMethod);
            pnlReceipt.Controls.Add(lblOrderDate);
            pnlReceipt.Controls.Add(lblOrderId);
            pnlReceipt.Controls.Add(lblReceiptTitle);
            pnlReceipt.Controls.Add(lblShopName);
            pnlReceipt.Dock = DockStyle.Fill;
            pnlReceipt.Location = new Point(0, 0);
            pnlReceipt.Name = "pnlReceipt";
            pnlReceipt.Size = new Size(382, 553);
            pnlReceipt.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(78, 52, 46);
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(130, 500);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(120, 40);
            btnPrint.TabIndex = 8;
            btnPrint.Text = "🖨 Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblReceiptTotal
            // 
            lblReceiptTotal.AutoSize = true;
            lblReceiptTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptTotal.ForeColor = Color.FromArgb(78, 52, 46);
            lblReceiptTotal.Location = new Point(260, 450);
            lblReceiptTotal.Name = "lblReceiptTotal";
            lblReceiptTotal.Size = new Size(107, 31);
            lblReceiptTotal.TabIndex = 7;
            lblReceiptTotal.Text = "0.000 DT";
            // 
            // lblReceiptTotalTitle
            // 
            lblReceiptTotalTitle.AutoSize = true;
            lblReceiptTotalTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptTotalTitle.ForeColor = Color.FromArgb(78, 52, 46);
            lblReceiptTotalTitle.Location = new Point(20, 450);
            lblReceiptTotalTitle.Name = "lblReceiptTotalTitle";
            lblReceiptTotalTitle.Size = new Size(87, 31);
            lblReceiptTotalTitle.TabIndex = 6;
            lblReceiptTotalTitle.Text = "TOTAL:";
            // 
            // dgvReceiptItems
            // 
            dgvReceiptItems.AllowUserToAddRows = false;
            dgvReceiptItems.AllowUserToDeleteRows = false;
            dgvReceiptItems.AllowUserToResizeColumns = false;
            dgvReceiptItems.AllowUserToResizeRows = false;
            dgvReceiptItems.BackgroundColor = Color.White;
            dgvReceiptItems.BorderStyle = BorderStyle.None;
            dgvReceiptItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReceiptItems.Columns.AddRange(new DataGridViewColumn[] { colReceiptProduct, colReceiptQuantity, colReceiptUnitPrice, colReceiptTotal });
            dgvReceiptItems.Location = new Point(20, 217);
            dgvReceiptItems.Name = "dgvReceiptItems";
            dgvReceiptItems.ReadOnly = true;
            dgvReceiptItems.RowHeadersVisible = false;
            dgvReceiptItems.RowHeadersWidth = 51;
            dgvReceiptItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceiptItems.Size = new Size(345, 218);
            dgvReceiptItems.TabIndex = 5;
            // 
            // colReceiptProduct
            // 
            colReceiptProduct.HeaderText = "Product";
            colReceiptProduct.MinimumWidth = 6;
            colReceiptProduct.Name = "colReceiptProduct";
            colReceiptProduct.ReadOnly = true;
            colReceiptProduct.Width = 130;
            // 
            // colReceiptQuantity
            // 
            colReceiptQuantity.HeaderText = "Qty";
            colReceiptQuantity.MinimumWidth = 6;
            colReceiptQuantity.Name = "colReceiptQuantity";
            colReceiptQuantity.ReadOnly = true;
            colReceiptQuantity.Width = 45;
            // 
            // colReceiptUnitPrice
            // 
            colReceiptUnitPrice.HeaderText = "Unit Price";
            colReceiptUnitPrice.MinimumWidth = 6;
            colReceiptUnitPrice.Name = "colReceiptUnitPrice";
            colReceiptUnitPrice.ReadOnly = true;
            colReceiptUnitPrice.Width = 80;
            // 
            // colReceiptTotal
            // 
            colReceiptTotal.HeaderText = "Total";
            colReceiptTotal.MinimumWidth = 6;
            colReceiptTotal.Name = "colReceiptTotal";
            colReceiptTotal.ReadOnly = true;
            colReceiptTotal.Width = 80;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentMethod.ForeColor = Color.FromArgb(85, 85, 85);
            lblPaymentMethod.Location = new Point(30, 150);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(104, 25);
            lblPaymentMethod.TabIndex = 4;
            lblPaymentMethod.Text = "Payment: -";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderDate.ForeColor = Color.FromArgb(85, 85, 85);
            lblOrderDate.Location = new Point(30, 125);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(69, 25);
            lblOrderDate.TabIndex = 3;
            lblOrderDate.Text = "Date: -";
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderId.ForeColor = Color.FromArgb(78, 52, 46);
            lblOrderId.Location = new Point(30, 100);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(97, 25);
            lblOrderId.TabIndex = 2;
            lblOrderId.Text = "Order #: 0";
            // 
            // lblReceiptTitle
            // 
            lblReceiptTitle.AutoSize = true;
            lblReceiptTitle.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptTitle.ForeColor = Color.Gray;
            lblReceiptTitle.Location = new Point(141, 69);
            lblReceiptTitle.Name = "lblReceiptTitle";
            lblReceiptTitle.Size = new Size(83, 25);
            lblReceiptTitle.TabIndex = 1;
            lblReceiptTitle.Text = "RECEIPT";
            // 
            // lblShopName
            // 
            lblShopName.AutoSize = true;
            lblShopName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShopName.ForeColor = Color.FromArgb(78, 52, 46);
            lblShopName.Location = new Point(65, 19);
            lblShopName.Name = "lblShopName";
            lblShopName.Size = new Size(251, 41);
            lblShopName.TabIndex = 0;
            lblShopName.Text = "No Stress Coffee";
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.ForeColor = Color.FromArgb(85, 85, 85);
            lblCashier.Location = new Point(30, 175);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(80, 25);
            lblCashier.TabIndex = 9;
            lblCashier.Text = "Cashier:";
            // 
            // frmReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 553);
            Controls.Add(pnlReceipt);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmReceipt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmReceipt";
            Load += frmReceipt_Load;
            pnlReceipt.ResumeLayout(false);
            pnlReceipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReceiptItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlReceipt;
        private Label lblShopName;
        private Label lblOrderId;
        private Label lblReceiptTitle;
        private Label lblPaymentMethod;
        private Label lblOrderDate;
        private DataGridView dgvReceiptItems;
        private DataGridViewTextBoxColumn colReceiptProduct;
        private DataGridViewTextBoxColumn colReceiptQuantity;
        private DataGridViewTextBoxColumn colReceiptUnitPrice;
        private DataGridViewTextBoxColumn colReceiptTotal;
        private Button btnPrint;
        private Label lblReceiptTotal;
        private Label lblReceiptTotalTitle;
        private Label lblCashier;
    }
}
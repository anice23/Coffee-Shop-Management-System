namespace CoffeSystem_1UI.Screens
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlProducts = new Panel();
            cmbCategoryFilter = new ComboBox();
            pictureBox1 = new PictureBox();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductPrice = new DataGridViewTextBoxColumn();
            colProductStock = new DataGridViewTextBoxColumn();
            txtSearchProduct = new TextBox();
            pnlProductsHeader = new Panel();
            lblProductsTitle = new Label();
            pnlCart = new Panel();
            btnCheckout = new Button();
            cmbPaymentMethod = new ComboBox();
            btnClearCart = new Button();
            lblGrandTotal = new Label();
            lblGrandTotalTitle = new Label();
            dgvCart = new DataGridView();
            colCartProduct = new DataGridViewTextBoxColumn();
            colCartQuantity = new DataGridViewTextBoxColumn();
            colCartUnitPrice = new DataGridViewTextBoxColumn();
            colCartTotal = new DataGridViewTextBoxColumn();
            colCartRemove = new DataGridViewTextBoxColumn();
            pnlCartHeader = new Panel();
            lblCartTitle = new Label();
            pnlProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlProductsHeader.SuspendLayout();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            pnlCartHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlProducts
            // 
            pnlProducts.BackColor = Color.Transparent;
            pnlProducts.Controls.Add(cmbCategoryFilter);
            pnlProducts.Controls.Add(pictureBox1);
            pnlProducts.Controls.Add(dgvProducts);
            pnlProducts.Controls.Add(txtSearchProduct);
            pnlProducts.Controls.Add(pnlProductsHeader);
            pnlProducts.Dock = DockStyle.Left;
            pnlProducts.Location = new Point(0, 0);
            pnlProducts.Name = "pnlProducts";
            pnlProducts.Size = new Size(650, 841);
            pnlProducts.TabIndex = 0;
            // 
            // cmbCategoryFilter
            // 
            cmbCategoryFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoryFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategoryFilter.FormattingEnabled = true;
            cmbCategoryFilter.Location = new Point(312, 75);
            cmbCategoryFilter.Name = "cmbCategoryFilter";
            cmbCategoryFilter.Size = new Size(200, 36);
            cmbCategoryFilter.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colProductPrice, colProductStock });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(20, 120);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(600, 517);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // colProductId
            // 
            colProductId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colProductId.HeaderText = "ID";
            colProductId.MinimumWidth = 6;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Resizable = DataGridViewTriState.False;
            colProductId.Width = 80;
            // 
            // colProductName
            // 
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductName.HeaderText = "Product";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Resizable = DataGridViewTriState.False;
            // 
            // colProductPrice
            // 
            colProductPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductPrice.HeaderText = "Price";
            colProductPrice.MinimumWidth = 6;
            colProductPrice.Name = "colProductPrice";
            colProductPrice.ReadOnly = true;
            colProductPrice.Resizable = DataGridViewTriState.False;
            // 
            // colProductStock
            // 
            colProductStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductStock.HeaderText = "Stock";
            colProductStock.MinimumWidth = 6;
            colProductStock.Name = "colProductStock";
            colProductStock.ReadOnly = true;
            colProductStock.Resizable = DataGridViewTriState.False;
            colProductStock.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchProduct.Location = new Point(56, 77);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(250, 34);
            txtSearchProduct.TabIndex = 2;
            // 
            // pnlProductsHeader
            // 
            pnlProductsHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlProductsHeader.Controls.Add(lblProductsTitle);
            pnlProductsHeader.Dock = DockStyle.Top;
            pnlProductsHeader.Location = new Point(0, 0);
            pnlProductsHeader.Name = "pnlProductsHeader";
            pnlProductsHeader.Size = new Size(650, 60);
            pnlProductsHeader.TabIndex = 1;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductsTitle.ForeColor = Color.White;
            lblProductsTitle.Location = new Point(20, 15);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(132, 38);
            lblProductsTitle.TabIndex = 0;
            lblProductsTitle.Text = "Products";
            // 
            // pnlCart
            // 
            pnlCart.BackColor = Color.WhiteSmoke;
            pnlCart.Controls.Add(btnCheckout);
            pnlCart.Controls.Add(cmbPaymentMethod);
            pnlCart.Controls.Add(btnClearCart);
            pnlCart.Controls.Add(lblGrandTotal);
            pnlCart.Controls.Add(lblGrandTotalTitle);
            pnlCart.Controls.Add(dgvCart);
            pnlCart.Controls.Add(pnlCartHeader);
            pnlCart.Dock = DockStyle.Fill;
            pnlCart.Location = new Point(650, 0);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(1000, 841);
            pnlCart.TabIndex = 1;
            // 
            // btnCheckout
            // 
            btnCheckout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckout.BackColor = Color.FromArgb(78, 52, 46);
            btnCheckout.FlatStyle = FlatStyle.Popup;
            btnCheckout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(20, 712);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(150, 45);
            btnCheckout.TabIndex = 8;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cmbPaymentMethod.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Location = new Point(20, 670);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(150, 36);
            cmbPaymentMethod.TabIndex = 7;
            // 
            // btnClearCart
            // 
            btnClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearCart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClearCart.BackColor = Color.FromArgb(78, 52, 46);
            btnClearCart.FlatStyle = FlatStyle.Popup;
            btnClearCart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(347, 597);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(120, 40);
            btnClearCart.TabIndex = 4;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.Transparent;
            lblGrandTotal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotal.ForeColor = Color.FromArgb(78, 52, 46);
            lblGrandTotal.Location = new Point(176, 606);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(107, 31);
            lblGrandTotal.TabIndex = 6;
            lblGrandTotal.Text = "0.000 DT";
            // 
            // lblGrandTotalTitle
            // 
            lblGrandTotalTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblGrandTotalTitle.AutoSize = true;
            lblGrandTotalTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrandTotalTitle.Location = new Point(26, 606);
            lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            lblGrandTotalTitle.Size = new Size(144, 31);
            lblGrandTotalTitle.TabIndex = 5;
            lblGrandTotalTitle.Text = "Grand Total:";
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AllowUserToResizeColumns = false;
            dgvCart.AllowUserToResizeRows = false;
            dgvCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCart.BackgroundColor = Color.White;
            dgvCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCartProduct, colCartQuantity, colCartUnitPrice, colCartTotal, colCartRemove });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.Location = new Point(20, 80);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(872, 511);
            dgvCart.TabIndex = 4;
            // 
            // colCartProduct
            // 
            colCartProduct.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartProduct.HeaderText = "Product";
            colCartProduct.MinimumWidth = 6;
            colCartProduct.Name = "colCartProduct";
            colCartProduct.ReadOnly = true;
            colCartProduct.Resizable = DataGridViewTriState.False;
            // 
            // colCartQuantity
            // 
            colCartQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartQuantity.HeaderText = "Qty";
            colCartQuantity.MinimumWidth = 6;
            colCartQuantity.Name = "colCartQuantity";
            colCartQuantity.ReadOnly = true;
            colCartQuantity.Resizable = DataGridViewTriState.False;
            // 
            // colCartUnitPrice
            // 
            colCartUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartUnitPrice.HeaderText = "Unit Price";
            colCartUnitPrice.MinimumWidth = 6;
            colCartUnitPrice.Name = "colCartUnitPrice";
            colCartUnitPrice.ReadOnly = true;
            colCartUnitPrice.Resizable = DataGridViewTriState.False;
            // 
            // colCartTotal
            // 
            colCartTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartTotal.HeaderText = "Total";
            colCartTotal.MinimumWidth = 6;
            colCartTotal.Name = "colCartTotal";
            colCartTotal.ReadOnly = true;
            colCartTotal.Resizable = DataGridViewTriState.False;
            // 
            // colCartRemove
            // 
            colCartRemove.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCartRemove.HeaderText = "Remove";
            colCartRemove.MinimumWidth = 6;
            colCartRemove.Name = "colCartRemove";
            colCartRemove.ReadOnly = true;
            colCartRemove.Resizable = DataGridViewTriState.False;
            // 
            // pnlCartHeader
            // 
            pnlCartHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlCartHeader.Controls.Add(lblCartTitle);
            pnlCartHeader.Dock = DockStyle.Top;
            pnlCartHeader.Location = new Point(0, 0);
            pnlCartHeader.Name = "pnlCartHeader";
            pnlCartHeader.Size = new Size(1000, 60);
            pnlCartHeader.TabIndex = 0;
            // 
            // lblCartTitle
            // 
            lblCartTitle.AutoSize = true;
            lblCartTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCartTitle.ForeColor = Color.White;
            lblCartTitle.Location = new Point(20, 15);
            lblCartTitle.Name = "lblCartTitle";
            lblCartTitle.Size = new Size(199, 38);
            lblCartTitle.TabIndex = 1;
            lblCartTitle.Text = "Current Order";
            // 
            // frmPOS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1650, 841);
            Controls.Add(pnlCart);
            Controls.Add(pnlProducts);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1400, 700);
            Name = "frmPOS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Point of Sale";
            WindowState = FormWindowState.Maximized;
            Load += frmPOS_Load;
            pnlProducts.ResumeLayout(false);
            pnlProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlProductsHeader.ResumeLayout(false);
            pnlProductsHeader.PerformLayout();
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            pnlCartHeader.ResumeLayout(false);
            pnlCartHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProducts;
        private Panel pnlCart;
        private TextBox txtSearchProduct;
        private Panel pnlProductsHeader;
        private Label lblProductsTitle;
        private DataGridView dgvProducts;
        private DataGridView dgvCart;
        private Panel pnlCartHeader;
        private Label lblCartTitle;
        private Label lblGrandTotal;
        private Label lblGrandTotalTitle;
        private Button btnClearCart;
        private ComboBox cmbPaymentMethod;
        private Button btnCheckout;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colProductPrice;
        private DataGridViewTextBoxColumn colProductStock;
        private DataGridViewTextBoxColumn colCartProduct;
        private DataGridViewTextBoxColumn colCartQuantity;
        private DataGridViewTextBoxColumn colCartUnitPrice;
        private DataGridViewTextBoxColumn colCartTotal;
        private DataGridViewTextBoxColumn colCartRemove;
        private ComboBox cmbCategoryFilter;
        private PictureBox pictureBox1;
    }
}
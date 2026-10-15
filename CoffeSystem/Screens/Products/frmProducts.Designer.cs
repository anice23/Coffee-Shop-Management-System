namespace CoffeSystem_1UI.Screens
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            pnlProductsHeader = new Panel();
            lblProductsTitle = new Label();
            btnAddProduct = new Button();
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductImage = new DataGridViewImageColumn();
            colProductPrice = new DataGridViewTextBoxColumn();
            colProductStock = new DataGridViewTextBoxColumn();
            colProductCategory = new DataGridViewTextBoxColumn();
            pnlActions = new Panel();
            btnClearFilters = new Button();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblSearchProduct = new Label();
            txtSearchProduct = new TextBox();
            btnInactiveProducts = new Button();
            lblNoProducts = new Label();
            pictureBox1 = new PictureBox();
            pnlProductsHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            pnlActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlProductsHeader
            // 
            pnlProductsHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlProductsHeader.Controls.Add(lblProductsTitle);
            pnlProductsHeader.Dock = DockStyle.Top;
            pnlProductsHeader.Location = new Point(0, 0);
            pnlProductsHeader.Name = "pnlProductsHeader";
            pnlProductsHeader.Size = new Size(1307, 60);
            pnlProductsHeader.TabIndex = 0;
            pnlProductsHeader.Paint += pnlProductsHeader_Paint;
            // 
            // lblProductsTitle
            // 
            lblProductsTitle.AutoSize = true;
            lblProductsTitle.BackColor = Color.Transparent;
            lblProductsTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblProductsTitle.ForeColor = Color.White;
            lblProductsTitle.Location = new Point(12, 9);
            lblProductsTitle.Name = "lblProductsTitle";
            lblProductsTitle.Size = new Size(296, 37);
            lblProductsTitle.TabIndex = 1;
            lblProductsTitle.Text = "Products Management";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddProduct.BackColor = Color.FromArgb(109, 76, 65);
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(1073, 6);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(175, 40);
            btnAddProduct.TabIndex = 3;
            btnAddProduct.Text = "+ Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colProductImage, colProductPrice, colProductStock, colProductCategory });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.Location = new Point(20, 134);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1152, 427);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colProductId
            // 
            colProductId.HeaderText = "ID";
            colProductId.MinimumWidth = 6;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            colProductId.Width = 60;
            // 
            // colProductName
            // 
            colProductName.HeaderText = "Product";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            colProductName.Width = 250;
            // 
            // colProductImage
            // 
            colProductImage.HeaderText = "Image";
            colProductImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colProductImage.MinimumWidth = 6;
            colProductImage.Name = "colProductImage";
            colProductImage.ReadOnly = true;
            colProductImage.Resizable = DataGridViewTriState.True;
            colProductImage.SortMode = DataGridViewColumnSortMode.Automatic;
            colProductImage.Width = 125;
            // 
            // colProductPrice
            // 
            colProductPrice.HeaderText = "Price";
            colProductPrice.MinimumWidth = 6;
            colProductPrice.Name = "colProductPrice";
            colProductPrice.ReadOnly = true;
            colProductPrice.Width = 120;
            // 
            // colProductStock
            // 
            colProductStock.HeaderText = "Stock";
            colProductStock.MinimumWidth = 6;
            colProductStock.Name = "colProductStock";
            colProductStock.ReadOnly = true;
            colProductStock.Resizable = DataGridViewTriState.False;
            colProductStock.Width = 125;
            // 
            // colProductCategory
            // 
            colProductCategory.HeaderText = "Category";
            colProductCategory.MinimumWidth = 6;
            colProductCategory.Name = "colProductCategory";
            colProductCategory.ReadOnly = true;
            colProductCategory.Width = 150;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.White;
            pnlActions.Controls.Add(pictureBox1);
            pnlActions.Controls.Add(btnClearFilters);
            pnlActions.Controls.Add(lblCategory);
            pnlActions.Controls.Add(cmbCategory);
            pnlActions.Controls.Add(lblSearchProduct);
            pnlActions.Controls.Add(txtSearchProduct);
            pnlActions.Controls.Add(btnInactiveProducts);
            pnlActions.Controls.Add(btnAddProduct);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 60);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1307, 68);
            pnlActions.TabIndex = 2;
            // 
            // btnClearFilters
            // 
            btnClearFilters.BackColor = Color.FromArgb(117, 117, 117);
            btnClearFilters.FlatStyle = FlatStyle.Flat;
            btnClearFilters.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClearFilters.ForeColor = Color.White;
            btnClearFilters.Location = new Point(361, 29);
            btnClearFilters.Name = "btnClearFilters";
            btnClearFilters.Size = new Size(70, 32);
            btnClearFilters.TabIndex = 8;
            btnClearFilters.Text = "Clear";
            btnClearFilters.UseVisualStyleBackColor = false;
            btnClearFilters.Click += btnClearFilters_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(78, 52, 46);
            lblCategory.Location = new Point(474, 5);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(102, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "📂  Category";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.White;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.FromArgb(60, 60, 60);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(474, 28);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 31);
            cmbCategory.TabIndex = 3;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblSearchProduct
            // 
            lblSearchProduct.AutoSize = true;
            lblSearchProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchProduct.ForeColor = Color.FromArgb(78, 52, 46);
            lblSearchProduct.Location = new Point(66, 7);
            lblSearchProduct.Name = "lblSearchProduct";
            lblSearchProduct.Size = new Size(139, 20);
            lblSearchProduct.TabIndex = 6;
            lblSearchProduct.Text = "🔍 Search Product\n";
            // 
            // txtSearchProduct
            // 
            txtSearchProduct.BackColor = Color.White;
            txtSearchProduct.BorderStyle = BorderStyle.FixedSingle;
            txtSearchProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchProduct.ForeColor = Color.Gray;
            txtSearchProduct.Location = new Point(66, 30);
            txtSearchProduct.Name = "txtSearchProduct";
            txtSearchProduct.Size = new Size(300, 31);
            txtSearchProduct.TabIndex = 5;
            txtSearchProduct.TextChanged += txtSearchProduct_TextChanged;
            // 
            // btnInactiveProducts
            // 
            btnInactiveProducts.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInactiveProducts.BackColor = Color.FromArgb(166, 123, 91);
            btnInactiveProducts.FlatStyle = FlatStyle.Flat;
            btnInactiveProducts.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInactiveProducts.ForeColor = Color.White;
            btnInactiveProducts.Location = new Point(855, 6);
            btnInactiveProducts.Name = "btnInactiveProducts";
            btnInactiveProducts.Size = new Size(175, 40);
            btnInactiveProducts.TabIndex = 4;
            btnInactiveProducts.Text = "Inactive Products";
            btnInactiveProducts.UseVisualStyleBackColor = false;
            btnInactiveProducts.Click += btnInactiveProducts_Click;
            // 
            // lblNoProducts
            // 
            lblNoProducts.AutoSize = true;
            lblNoProducts.BackColor = Color.White;
            lblNoProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoProducts.ForeColor = Color.FromArgb(117, 117, 117);
            lblNoProducts.Location = new Point(407, 298);
            lblNoProducts.Name = "lblNoProducts";
            lblNoProducts.Size = new Size(191, 28);
            lblNoProducts.TabIndex = 8;
            lblNoProducts.Text = "No products found";
            lblNoProducts.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1307, 662);
            Controls.Add(lblNoProducts);
            Controls.Add(pnlActions);
            Controls.Add(dgvProducts);
            Controls.Add(pnlProductsHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1200, 650);
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products Management";
            WindowState = FormWindowState.Maximized;
            Load += frmProducts_Load;
            pnlProductsHeader.ResumeLayout(false);
            pnlProductsHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlProductsHeader;
        private Label lblProductsTitle;
        private DataGridView dgvProducts;
        private Button btnAddProduct;
        private Panel pnlActions;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewImageColumn colProductImage;
        private DataGridViewTextBoxColumn colProductPrice;
        private DataGridViewTextBoxColumn colProductStock;
        private DataGridViewTextBoxColumn colProductCategory;
        private Button btnInactiveProducts;
        private Label lblSearchProduct;
        private TextBox txtSearchProduct;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblNoProducts;
        private Button btnClearFilters;
        private PictureBox pictureBox1;
    }
}
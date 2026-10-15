namespace CoffeSystem_1UI.Screens
{
    partial class frmInactiveProducts
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
            dgvInactiveProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductImage = new DataGridViewImageColumn();
            colProductPrice = new DataGridViewTextBoxColumn();
            colProductStock = new DataGridViewTextBoxColumn();
            colProductCategory = new DataGridViewTextBoxColumn();
            colRestore = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvInactiveProducts).BeginInit();
            SuspendLayout();
            // 
            // dgvInactiveProducts
            // 
            dgvInactiveProducts.AllowUserToAddRows = false;
            dgvInactiveProducts.BackgroundColor = Color.White;
            dgvInactiveProducts.BorderStyle = BorderStyle.None;
            dgvInactiveProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInactiveProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInactiveProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInactiveProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colProductImage, colProductPrice, colProductStock, colProductCategory, colRestore });
            dgvInactiveProducts.Dock = DockStyle.Fill;
            dgvInactiveProducts.GridColor = Color.LightGray;
            dgvInactiveProducts.Location = new Point(0, 0);
            dgvInactiveProducts.Name = "dgvInactiveProducts";
            dgvInactiveProducts.ReadOnly = true;
            dgvInactiveProducts.RowHeadersVisible = false;
            dgvInactiveProducts.RowHeadersWidth = 51;
            dgvInactiveProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInactiveProducts.Size = new Size(1105, 636);
            dgvInactiveProducts.TabIndex = 0;
            dgvInactiveProducts.CellContentClick += dgvInactiveProducts_CellContentClick;
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
            colProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colProductName.HeaderText = "Product Name";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colProductImage
            // 
            colProductImage.HeaderText = "Image";
            colProductImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colProductImage.MinimumWidth = 6;
            colProductImage.Name = "colProductImage";
            colProductImage.ReadOnly = true;
            colProductImage.Width = 125;
            // 
            // colProductPrice
            // 
            colProductPrice.HeaderText = "Price";
            colProductPrice.MinimumWidth = 6;
            colProductPrice.Name = "colProductPrice";
            colProductPrice.ReadOnly = true;
            colProductPrice.Width = 130;
            // 
            // colProductStock
            // 
            colProductStock.HeaderText = "Stock";
            colProductStock.MinimumWidth = 6;
            colProductStock.Name = "colProductStock";
            colProductStock.ReadOnly = true;
            colProductStock.Width = 120;
            // 
            // colProductCategory
            // 
            colProductCategory.HeaderText = "Category";
            colProductCategory.MinimumWidth = 6;
            colProductCategory.Name = "colProductCategory";
            colProductCategory.ReadOnly = true;
            colProductCategory.Width = 200;
            // 
            // colRestore
            // 
            colRestore.HeaderText = "Restore";
            colRestore.MinimumWidth = 6;
            colRestore.Name = "colRestore";
            colRestore.ReadOnly = true;
            colRestore.UseColumnTextForButtonValue = true;
            colRestore.Width = 120;
            // 
            // frmInactiveProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1105, 636);
            Controls.Add(dgvInactiveProducts);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmInactiveProducts";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Inactive Products";
            Load += frmInactiveProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInactiveProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInactiveProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewImageColumn colProductImage;
        private DataGridViewTextBoxColumn colProductPrice;
        private DataGridViewTextBoxColumn colProductStock;
        private DataGridViewTextBoxColumn colProductCategory;
        private DataGridViewButtonColumn colRestore;
    }
}
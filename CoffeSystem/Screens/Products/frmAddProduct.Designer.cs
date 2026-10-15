namespace CoffeSystem_1UI.Screens
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            lblStock = new Label();
            nudStock = new NumericUpDown();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblImage = new Label();
            picProduct = new PictureBox();
            btnChooseImage = new Button();
            btnCancel = new Button();
            btnAdd = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(511, 60);
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
            lblTitle.Size = new Size(171, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add Product";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(78, 52, 46);
            lblProductName.Location = new Point(30, 85);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 23);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.BorderStyle = BorderStyle.FixedSingle;
            txtProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(30, 108);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(430, 31);
            txtProductName.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(78, 52, 46);
            lblPrice.Location = new Point(30, 155);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 3;
            nudPrice.Increment = new decimal(new int[] { 100, 0, 0, 196608 });
            nudPrice.Location = new Point(30, 178);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(430, 27);
            nudPrice.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(78, 52, 46);
            lblStock.Location = new Point(30, 225);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 23);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // nudStock
            // 
            nudStock.Location = new Point(30, 248);
            nudStock.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(430, 27);
            nudStock.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(78, 52, 46);
            lblCategory.Location = new Point(30, 295);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 23);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(30, 318);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(430, 28);
            cmbCategory.TabIndex = 9;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.BackColor = Color.Transparent;
            lblImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImage.ForeColor = Color.FromArgb(78, 52, 46);
            lblImage.Location = new Point(30, 365);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(128, 23);
            lblImage.TabIndex = 10;
            lblImage.Text = "Product Image";
            // 
            // picProduct
            // 
            picProduct.Location = new Point(30, 390);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(125, 80);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 11;
            picProduct.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(109, 76, 65);
            btnChooseImage.Cursor = Cursors.Hand;
            btnChooseImage.FlatAppearance.BorderSize = 0;
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(30, 480);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(125, 35);
            btnChooseImage.TabIndex = 12;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 189, 189);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(33, 33, 33);
            btnCancel.Location = new Point(220, 525);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(78, 52, 46);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(330, 525);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(511, 587);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(btnChooseImage);
            Controls.Add(picProduct);
            Controls.Add(lblImage);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(nudStock);
            Controls.Add(lblStock);
            Controls.Add(nudPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddProduct";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Product";
            Load += frmAddProduct_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblProductName;
        private TextBox txtProductName;
        private Label lblPrice;
        private NumericUpDown nudPrice;
        private Label lblStock;
        private NumericUpDown nudStock;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblImage;
        private PictureBox picProduct;
        private Button btnChooseImage;
        private Button btnCancel;
        private Button btnAdd;
    }
}
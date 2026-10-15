namespace CoffeSystem_1UI.Screens
{
    partial class frmEditProduct
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
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblPrice = new Label();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            lblStock = new Label();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblImage = new Label();
            picProduct = new PictureBox();
            btnChooseImage = new Button();
            btnUpdate = new Button();
            btnCancel = new Button();
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
            pnlHeader.Size = new Size(482, 53);
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
            lblTitle.Size = new Size(168, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Product";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.BackColor = Color.Transparent;
            lblProductName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.ForeColor = Color.FromArgb(78, 52, 46);
            lblProductName.Location = new Point(30, 90);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(125, 23);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(30, 115);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(400, 31);
            txtProductName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = Color.FromArgb(78, 52, 46);
            lblPrice.Location = new Point(30, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(49, 23);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 3;
            nudPrice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrice.Increment = new decimal(new int[] { 100, 0, 0, 196608 });
            nudPrice.Location = new Point(30, 185);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(400, 31);
            nudPrice.TabIndex = 4;
            // 
            // nudStock
            // 
            nudStock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudStock.Location = new Point(30, 255);
            nudStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(400, 31);
            nudStock.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Transparent;
            lblStock.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.FromArgb(78, 52, 46);
            lblStock.Location = new Point(30, 230);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(55, 23);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Transparent;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(78, 52, 46);
            lblCategory.Location = new Point(30, 300);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(84, 23);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(30, 325);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(400, 33);
            cmbCategory.TabIndex = 8;
            cmbCategory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblImage
            // 
            lblImage.AutoSize = true;
            lblImage.BackColor = Color.Transparent;
            lblImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImage.ForeColor = Color.FromArgb(78, 52, 46);
            lblImage.Location = new Point(30, 370);
            lblImage.Name = "lblImage";
            lblImage.Size = new Size(128, 23);
            lblImage.TabIndex = 9;
            lblImage.Text = "Product Image";
            // 
            // picProduct
            // 
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(30, 395);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(100, 80);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 10;
            picProduct.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.BackColor = Color.FromArgb(78, 52, 46);
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseImage.ForeColor = Color.White;
            btnChooseImage.Location = new Point(150, 415);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(120, 35);
            btnChooseImage.TabIndex = 11;
            btnChooseImage.Text = "Choose Image";
            btnChooseImage.UseVisualStyleBackColor = false;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(78, 52, 46);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(180, 510);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 40);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(117, 117, 117);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(310, 510);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(482, 553);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(btnChooseImage);
            Controls.Add(picProduct);
            Controls.Add(lblImage);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(lblStock);
            Controls.Add(nudStock);
            Controls.Add(nudPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblProductName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Product";
            Load += frmEditProduct_Load;
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
        private NumericUpDown nudStock;
        private Label lblStock;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblImage;
        private PictureBox picProduct;
        private Button btnChooseImage;
        private Button btnUpdate;
        private Button btnCancel;
    }
}
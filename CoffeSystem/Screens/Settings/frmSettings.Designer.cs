namespace CoffeSystem_1UI.Screens.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            pnlHeader = new Panel();
            lblSubtitle = new Label();
            lblTitle = new Label();
            pnlSettingsContent = new Panel();
            pnlCafeInfo = new Panel();
            btnSaveCafeInfo = new Button();
            numLowStockThreshold = new NumericUpDown();
            lblLowStockThreshold = new Label();
            txtReceiptFooter = new TextBox();
            lblReceiptFooter = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtCafeName = new TextBox();
            lblCafeName = new Label();
            lblCafeInfoTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlSettingsContent.SuspendLayout();
            pnlCafeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLowStockThreshold).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(62, 39, 35);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(681, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 9F);
            lblSubtitle.ForeColor = Color.FromArgb(232, 223, 213);
            lblSubtitle.Location = new Point(12, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(320, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Manage your cafe information and preferences";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(102, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Settings";
            // 
            // pnlSettingsContent
            // 
            pnlSettingsContent.BackColor = Color.FromArgb(245, 241, 236);
            pnlSettingsContent.Controls.Add(pnlCafeInfo);
            pnlSettingsContent.Dock = DockStyle.Fill;
            pnlSettingsContent.Location = new Point(0, 65);
            pnlSettingsContent.Name = "pnlSettingsContent";
            pnlSettingsContent.Size = new Size(681, 488);
            pnlSettingsContent.TabIndex = 1;
            // 
            // pnlCafeInfo
            // 
            pnlCafeInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlCafeInfo.BackColor = Color.White;
            pnlCafeInfo.Controls.Add(btnSaveCafeInfo);
            pnlCafeInfo.Controls.Add(numLowStockThreshold);
            pnlCafeInfo.Controls.Add(lblLowStockThreshold);
            pnlCafeInfo.Controls.Add(txtReceiptFooter);
            pnlCafeInfo.Controls.Add(lblReceiptFooter);
            pnlCafeInfo.Controls.Add(txtPhoneNumber);
            pnlCafeInfo.Controls.Add(lblPhoneNumber);
            pnlCafeInfo.Controls.Add(txtAddress);
            pnlCafeInfo.Controls.Add(lblAddress);
            pnlCafeInfo.Controls.Add(txtCafeName);
            pnlCafeInfo.Controls.Add(lblCafeName);
            pnlCafeInfo.Controls.Add(lblCafeInfoTitle);
            pnlCafeInfo.Location = new Point(0, 0);
            pnlCafeInfo.Name = "pnlCafeInfo";
            pnlCafeInfo.Size = new Size(681, 488);
            pnlCafeInfo.TabIndex = 0;
            // 
            // btnSaveCafeInfo
            // 
            btnSaveCafeInfo.BackColor = Color.FromArgb(111, 78, 55);
            btnSaveCafeInfo.Cursor = Cursors.Hand;
            btnSaveCafeInfo.FlatAppearance.BorderSize = 0;
            btnSaveCafeInfo.FlatAppearance.MouseDownBackColor = Color.FromArgb(78, 52, 46);
            btnSaveCafeInfo.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 39, 35);
            btnSaveCafeInfo.FlatStyle = FlatStyle.Flat;
            btnSaveCafeInfo.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveCafeInfo.ForeColor = Color.White;
            btnSaveCafeInfo.Location = new Point(473, 382);
            btnSaveCafeInfo.Name = "btnSaveCafeInfo";
            btnSaveCafeInfo.Size = new Size(165, 42);
            btnSaveCafeInfo.TabIndex = 11;
            btnSaveCafeInfo.Text = "Save Information";
            btnSaveCafeInfo.UseVisualStyleBackColor = false;
            btnSaveCafeInfo.Click += btnSaveCafeInfo_Click;
            // 
            // numLowStockThreshold
            // 
            numLowStockThreshold.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numLowStockThreshold.Location = new Point(20, 358);
            numLowStockThreshold.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numLowStockThreshold.Name = "numLowStockThreshold";
            numLowStockThreshold.Size = new Size(98, 31);
            numLowStockThreshold.TabIndex = 10;
            numLowStockThreshold.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // lblLowStockThreshold
            // 
            lblLowStockThreshold.AutoSize = true;
            lblLowStockThreshold.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockThreshold.Location = new Point(20, 330);
            lblLowStockThreshold.Name = "lblLowStockThreshold";
            lblLowStockThreshold.Size = new Size(182, 25);
            lblLowStockThreshold.TabIndex = 9;
            lblLowStockThreshold.Text = "Low Stock Threshold";
            // 
            // txtReceiptFooter
            // 
            txtReceiptFooter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtReceiptFooter.Location = new Point(20, 282);
            txtReceiptFooter.Name = "txtReceiptFooter";
            txtReceiptFooter.Size = new Size(590, 34);
            txtReceiptFooter.TabIndex = 8;
            // 
            // lblReceiptFooter
            // 
            lblReceiptFooter.AutoSize = true;
            lblReceiptFooter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReceiptFooter.Location = new Point(20, 260);
            lblReceiptFooter.Name = "lblReceiptFooter";
            lblReceiptFooter.Size = new Size(134, 25);
            lblReceiptFooter.TabIndex = 7;
            lblReceiptFooter.Text = "Receipt Footer";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(20, 217);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(590, 34);
            txtPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhoneNumber.Location = new Point(20, 195);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(139, 25);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(20, 152);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(590, 34);
            txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(20, 130);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 25);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // txtCafeName
            // 
            txtCafeName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCafeName.Location = new Point(20, 87);
            txtCafeName.Name = "txtCafeName";
            txtCafeName.Size = new Size(590, 34);
            txtCafeName.TabIndex = 2;
            // 
            // lblCafeName
            // 
            lblCafeName.AutoSize = true;
            lblCafeName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCafeName.Location = new Point(20, 59);
            lblCafeName.Name = "lblCafeName";
            lblCafeName.Size = new Size(102, 25);
            lblCafeName.TabIndex = 1;
            lblCafeName.Text = "Cafe Name";
            // 
            // lblCafeInfoTitle
            // 
            lblCafeInfoTitle.AutoSize = true;
            lblCafeInfoTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblCafeInfoTitle.ForeColor = Color.FromArgb(62, 39, 35);
            lblCafeInfoTitle.Location = new Point(20, 15);
            lblCafeInfoTitle.Name = "lblCafeInfoTitle";
            lblCafeInfoTitle.Size = new Size(199, 32);
            lblCafeInfoTitle.TabIndex = 0;
            lblCafeInfoTitle.Text = "Cafe Information";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(681, 553);
            Controls.Add(pnlSettingsContent);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += frmSettings_Load;
            Shown += frmSettings_Shown;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlSettingsContent.ResumeLayout(false);
            pnlCafeInfo.ResumeLayout(false);
            pnlCafeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLowStockThreshold).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubtitle;
        private Panel pnlSettingsContent;
        private Panel pnlCafeInfo;
        private Label lblCafeName;
        private Label lblCafeInfoTitle;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtCafeName;
        private Button btnSaveCafeInfo;
        private NumericUpDown numLowStockThreshold;
        private Label lblLowStockThreshold;
        private TextBox txtReceiptFooter;
        private Label lblReceiptFooter;
    }
}
namespace CoffeSystem_1UI.Screens
{
    partial class frmEditCategory
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
            lblName = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(78, 52, 46);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(510, 52);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(134, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Edit Category";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(62, 39, 35);
            lblName.Location = new Point(30, 90);
            lblName.Name = "lblName";
            lblName.Size = new Size(142, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Category Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(62, 39, 35);
            txtName.Location = new Point(30, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(430, 31);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(62, 39, 35);
            lblDescription.Location = new Point(30, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(108, 25);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.FromArgb(62, 39, 35);
            txtDescription.Location = new Point(30, 190);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(430, 31);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(78, 52, 46);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(80, 270);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 44);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 214, 207);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(62, 39, 35);
            btnCancel.Location = new Point(236, 270);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 44);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // frmEditCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(510, 350);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Category";
            Load += frmEditCategory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblName;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}
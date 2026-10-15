namespace CoffeSystem_1UI.Screens
{
    partial class frmAddCategory
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
            label1 = new Label();
            txtName = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnAdd = new Button();
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
            pnlHeader.Size = new Size(482, 50);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(62, 39, 35);
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(154, 28);
            label1.TabIndex = 1;
            label1.Text = "Category Name";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(62, 39, 35);
            txtName.Location = new Point(30, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(430, 34);
            txtName.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(62, 39, 35);
            lblDescription.Location = new Point(30, 165);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(115, 28);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.FromArgb(62, 39, 35);
            txtDescription.Location = new Point(30, 190);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(430, 34);
            txtDescription.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 214, 207);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(62, 39, 35);
            btnCancel.Location = new Point(222, 264);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 40);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(111, 78, 55);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(73, 264);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 40);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Category";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmAddCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 241, 236);
            ClientSize = new Size(482, 327);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddCategory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Category";
            Load += frmAddCategory_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label label1;
        private TextBox txtName;
        private Label lblDescription;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnAdd;
    }
}
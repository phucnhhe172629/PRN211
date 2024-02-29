namespace SalesWinApp
{
    partial class frmProductDetail
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
            txtProductName = new TextBox();
            lbProductName = new Label();
            txtCategoryID = new TextBox();
            lbCategoryID = new Label();
            txtProductID = new TextBox();
            lbProductID = new Label();
            lbWeight = new Label();
            txtWeight = new TextBox();
            lbUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbUnitsInStock = new Label();
            txtUnitsInStock = new TextBox();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(137, 150);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 27);
            txtProductName.TabIndex = 2;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(30, 150);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(104, 20);
            lbProductName.TabIndex = 2;
            lbProductName.Text = "Product Name";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(137, 100);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(250, 27);
            txtCategoryID.TabIndex = 1;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new Point(30, 100);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new Size(88, 20);
            lbCategoryID.TabIndex = 3;
            lbCategoryID.Text = "Category ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(137, 50);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(250, 27);
            txtProductID.TabIndex = 0;
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new Point(30, 50);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new Size(79, 20);
            lbProductID.TabIndex = 4;
            lbProductID.Text = "Product ID";
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new Point(30, 200);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new Size(56, 20);
            lbWeight.TabIndex = 3;
            lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(137, 200);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(250, 27);
            txtWeight.TabIndex = 3;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(30, 250);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(72, 20);
            lbUnitPrice.TabIndex = 2;
            lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(137, 250);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(250, 27);
            txtUnitPrice.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(114, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(249, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new Point(30, 300);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new Size(98, 20);
            lbUnitsInStock.TabIndex = 2;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new Point(137, 300);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new Size(250, 27);
            txtUnitsInStock.TabIndex = 5;
            // 
            // frmProductDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(421, 423);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUnitsInStock);
            Controls.Add(lbUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtWeight);
            Controls.Add(lbProductName);
            Controls.Add(lbWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(lbCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Name = "frmProductDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberDetails";
            Load += frmProductDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsInStock;
    }
}
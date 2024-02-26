namespace SalesWinApp
{
    partial class frmProductManagement
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
            lbProductID = new System.Windows.Forms.Label();
            txtProductID = new System.Windows.Forms.TextBox();
            lbCategoryID = new System.Windows.Forms.Label();
            txtCategoryID = new System.Windows.Forms.TextBox();
            lbProductName = new System.Windows.Forms.Label();
            txtProductName = new System.Windows.Forms.TextBox();
            lbWeight = new System.Windows.Forms.Label();
            txtWeight = new System.Windows.Forms.TextBox();
            lbUnitPrice = new System.Windows.Forms.Label();
            txtUnitPrice = new System.Windows.Forms.TextBox();
            dgvProductList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            cbSearch = new System.Windows.Forms.ComboBox();
            lbSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            lbUnitsInStock = new System.Windows.Forms.Label();
            txtUnitsInStock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // lbProductID
            // 
            lbProductID.AutoSize = true;
            lbProductID.Location = new System.Drawing.Point(60, 50);
            lbProductID.Name = "lbProductID";
            lbProductID.Size = new System.Drawing.Size(79, 20);
            lbProductID.TabIndex = 0;
            lbProductID.Text = "Product ID";
            // 
            // txtProductID
            // 
            txtProductID.Location = new System.Drawing.Point(175, 47);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new System.Drawing.Size(254, 27);
            txtProductID.TabIndex = 1;
            // 
            // lbCategoryID
            // 
            lbCategoryID.AutoSize = true;
            lbCategoryID.Location = new System.Drawing.Point(60, 100);
            lbCategoryID.Name = "lbCategoryID";
            lbCategoryID.Size = new System.Drawing.Size(88, 20);
            lbCategoryID.TabIndex = 0;
            lbCategoryID.Text = "Category ID";
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new System.Drawing.Point(175, 97);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new System.Drawing.Size(254, 27);
            txtCategoryID.TabIndex = 1;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new System.Drawing.Point(60, 150);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new System.Drawing.Size(104, 20);
            lbProductName.TabIndex = 0;
            lbProductName.Text = "Product Name";
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(175, 147);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new System.Drawing.Size(254, 27);
            txtProductName.TabIndex = 1;
            // 
            // lbWeight
            // 
            lbWeight.AutoSize = true;
            lbWeight.Location = new System.Drawing.Point(482, 50);
            lbWeight.Name = "lbWeight";
            lbWeight.Size = new System.Drawing.Size(56, 20);
            lbWeight.TabIndex = 0;
            lbWeight.Text = "Weight";
            // 
            // txtWeight
            // 
            txtWeight.Location = new System.Drawing.Point(590, 47);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new System.Drawing.Size(254, 27);
            txtWeight.TabIndex = 1;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new System.Drawing.Point(482, 100);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            lbUnitPrice.TabIndex = 0;
            lbUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new System.Drawing.Point(590, 97);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new System.Drawing.Size(254, 27);
            txtUnitPrice.TabIndex = 1;
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new System.Drawing.Point(12, 265);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.ReadOnly = true;
            dgvProductList.RowHeadersWidth = 51;
            dgvProductList.RowTemplate.Height = 29;
            dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProductList.Size = new System.Drawing.Size(845, 242);
            dgvProductList.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(12, 230);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new System.Drawing.Point(200, 190);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(600, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(400, 513);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(400, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbSearch
            // 
            cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "ID", "Name", "Unit Price", "Units In Stock" });
            cbSearch.Location = new System.Drawing.Point(632, 231);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new System.Drawing.Size(94, 28);
            cbSearch.TabIndex = 4;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(553, 236);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(73, 20);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search by";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(732, 231);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(125, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lbUnitsInStock
            // 
            lbUnitsInStock.AutoSize = true;
            lbUnitsInStock.Location = new System.Drawing.Point(482, 150);
            lbUnitsInStock.Name = "lbUnitsInStock";
            lbUnitsInStock.Size = new System.Drawing.Size(98, 20);
            lbUnitsInStock.TabIndex = 0;
            lbUnitsInStock.Text = "Units In Stock";
            // 
            // txtUnitsInStock
            // 
            txtUnitsInStock.Location = new System.Drawing.Point(590, 147);
            txtUnitsInStock.Name = "txtUnitsInStock";
            txtUnitsInStock.Size = new System.Drawing.Size(254, 27);
            txtUnitsInStock.TabIndex = 1;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(882, 546);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(cbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dgvProductList);
            Controls.Add(txtProductName);
            Controls.Add(lbProductName);
            Controls.Add(txtUnitsInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(lbUnitsInStock);
            Controls.Add(txtCategoryID);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbCategoryID);
            Controls.Add(txtWeight);
            Controls.Add(lbWeight);
            Controls.Add(txtProductID);
            Controls.Add(lbProductID);
            Name = "frmProductManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Product Management";
            Load += frmProductManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbCategoryID;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbUnitsInStock;
        private System.Windows.Forms.TextBox txtUnitsInStock;
    }
}
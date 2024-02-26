namespace SalesWinApp
{
    partial class frmOrderManagement
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
            dgvOrderList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            txtMemberID = new System.Windows.Forms.TextBox();
            lbMemberID = new System.Windows.Forms.Label();
            txtOrderID = new System.Windows.Forms.TextBox();
            lbOrderID = new System.Windows.Forms.Label();
            txtFreight = new System.Windows.Forms.TextBox();
            lbFreight = new System.Windows.Forms.Label();
            txtShippedDate = new System.Windows.Forms.TextBox();
            lbShippedDate = new System.Windows.Forms.Label();
            txtOrderDate = new System.Windows.Forms.TextBox();
            txtRequiredDate = new System.Windows.Forms.TextBox();
            lbOrderDate = new System.Windows.Forms.Label();
            lbRequiredDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new System.Drawing.Point(12, 236);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new System.Drawing.Size(845, 242);
            dgvOrderList.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(12, 201);
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
            btnClose.Location = new System.Drawing.Point(400, 484);
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
            // txtMemberID
            // 
            txtMemberID.Location = new System.Drawing.Point(165, 97);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new System.Drawing.Size(250, 27);
            txtMemberID.TabIndex = 11;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new System.Drawing.Point(60, 100);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new System.Drawing.Size(80, 20);
            lbMemberID.TabIndex = 12;
            lbMemberID.Text = "MemberID";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new System.Drawing.Point(165, 47);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new System.Drawing.Size(250, 27);
            txtOrderID.TabIndex = 10;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new System.Drawing.Point(60, 50);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new System.Drawing.Size(62, 20);
            lbOrderID.TabIndex = 13;
            lbOrderID.Text = "OrderID";
            // 
            // txtFreight
            // 
            txtFreight.Location = new System.Drawing.Point(165, 147);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new System.Drawing.Size(250, 27);
            txtFreight.TabIndex = 15;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new System.Drawing.Point(60, 150);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new System.Drawing.Size(55, 20);
            lbFreight.TabIndex = 14;
            lbFreight.Text = "Freight";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new System.Drawing.Point(585, 147);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new System.Drawing.Size(250, 27);
            txtShippedDate.TabIndex = 21;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new System.Drawing.Point(475, 150);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new System.Drawing.Size(96, 20);
            lbShippedDate.TabIndex = 16;
            lbShippedDate.Text = "ShippedDate";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new System.Drawing.Point(585, 47);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new System.Drawing.Size(250, 27);
            txtOrderDate.TabIndex = 17;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new System.Drawing.Point(585, 97);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new System.Drawing.Size(250, 27);
            txtRequiredDate.TabIndex = 19;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new System.Drawing.Point(475, 50);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new System.Drawing.Size(79, 20);
            lbOrderDate.TabIndex = 18;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new System.Drawing.Point(475, 100);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new System.Drawing.Size(101, 20);
            lbRequiredDate.TabIndex = 20;
            lbRequiredDate.Text = "RequiredDate";
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(870, 522);
            Controls.Add(txtShippedDate);
            Controls.Add(lbShippedDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtRequiredDate);
            Controls.Add(lbOrderDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dgvOrderList);
            Name = "frmOrderManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += frmOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.Label lbRequiredDate;
    }
}
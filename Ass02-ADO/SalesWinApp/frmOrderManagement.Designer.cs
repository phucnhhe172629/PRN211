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
            dgvOrderList = new DataGridView();
            btnLoad = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            txtFreight = new TextBox();
            lbFreight = new Label();
            txtShippedDate = new TextBox();
            lbShippedDate = new Label();
            txtOrderDate = new TextBox();
            txtRequiredDate = new TextBox();
            lbOrderDate = new Label();
            lbRequiredDate = new Label();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtTo = new TextBox();
            txtFrom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrderList
            // 
            dgvOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderList.Location = new Point(13, 289);
            dgvOrderList.Name = "dgvOrderList";
            dgvOrderList.ReadOnly = true;
            dgvOrderList.RowHeadersWidth = 51;
            dgvOrderList.RowTemplate.Height = 29;
            dgvOrderList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderList.Size = new Size(845, 242);
            dgvOrderList.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 252);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(200, 190);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(600, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(400, 537);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(400, 190);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(165, 97);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(250, 27);
            txtMemberID.TabIndex = 11;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(60, 100);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 12;
            lbMemberID.Text = "MemberID";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(165, 47);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(250, 27);
            txtOrderID.TabIndex = 10;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(60, 50);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(62, 20);
            lbOrderID.TabIndex = 13;
            lbOrderID.Text = "OrderID";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(165, 147);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(250, 27);
            txtFreight.TabIndex = 15;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(60, 150);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(55, 20);
            lbFreight.TabIndex = 14;
            lbFreight.Text = "Freight";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(585, 147);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(250, 27);
            txtShippedDate.TabIndex = 21;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(475, 150);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(96, 20);
            lbShippedDate.TabIndex = 16;
            lbShippedDate.Text = "ShippedDate";
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(585, 47);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(250, 27);
            txtOrderDate.TabIndex = 17;
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(585, 97);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(250, 27);
            txtRequiredDate.TabIndex = 19;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(475, 50);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(79, 20);
            lbOrderDate.TabIndex = 18;
            lbOrderDate.Text = "OrderDate";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(475, 100);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(101, 20);
            lbRequiredDate.TabIndex = 20;
            lbRequiredDate.Text = "RequiredDate";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtTo);
            groupBox1.Controls.Add(txtFrom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(165, 225);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(547, 58);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(435, 22);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(263, 24);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(143, 27);
            txtTo.TabIndex = 2;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(59, 24);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(143, 27);
            txtFrom.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(235, 27);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(764, 254);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 23;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            // 
            // frmOrderManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(870, 571);
            Controls.Add(btnSort);
            Controls.Add(groupBox1);
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management";
            Load += frmOrderManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOrderList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtTo;
        private TextBox txtFrom;
        private Label label2;
        private Label label1;
        private Button btnSort;
    }
}
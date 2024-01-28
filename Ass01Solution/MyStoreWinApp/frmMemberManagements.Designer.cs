namespace MyStoreWinApp
{
    partial class frmMemberManagements
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
            lbID = new System.Windows.Forms.Label();
            txtID = new System.Windows.Forms.TextBox();
            lbName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lbEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lbCity = new System.Windows.Forms.Label();
            txtCity = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtCountry = new System.Windows.Forms.TextBox();
            dgvMemberList = new System.Windows.Forms.DataGridView();
            btnLoad = new System.Windows.Forms.Button();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            cbSearch = new System.Windows.Forms.ComboBox();
            cbFilterBy = new System.Windows.Forms.ComboBox();
            lbSearch = new System.Windows.Forms.Label();
            lbFilter = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            cbFilter = new System.Windows.Forms.ComboBox();
            btnSort = new System.Windows.Forms.Button();
            lbSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new System.Drawing.Point(60, 50);
            lbID.Name = "lbID";
            lbID.Size = new System.Drawing.Size(24, 20);
            lbID.TabIndex = 0;
            lbID.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(135, 47);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(254, 27);
            txtID.TabIndex = 1;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(60, 100);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(49, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(135, 97);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(254, 27);
            txtName.TabIndex = 1;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new System.Drawing.Point(60, 150);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new System.Drawing.Size(46, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(135, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(254, 27);
            txtEmail.TabIndex = 1;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new System.Drawing.Point(482, 50);
            lbCity.Name = "lbCity";
            lbCity.Size = new System.Drawing.Size(34, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new System.Drawing.Point(557, 47);
            txtCity.Name = "txtCity";
            txtCity.Size = new System.Drawing.Size(254, 27);
            txtCity.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(482, 100);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(60, 20);
            label5.TabIndex = 0;
            label5.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new System.Drawing.Point(557, 97);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new System.Drawing.Size(254, 27);
            txtCountry.TabIndex = 1;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new System.Drawing.Point(12, 314);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.ReadOnly = true;
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvMemberList.Size = new System.Drawing.Size(845, 242);
            dgvMemberList.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(12, 279);
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
            btnClose.Location = new System.Drawing.Point(400, 562);
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
            cbSearch.Items.AddRange(new object[] { "ID", "Name" });
            cbSearch.Location = new System.Drawing.Point(100, 242);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new System.Drawing.Size(94, 28);
            cbSearch.TabIndex = 4;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "City", "Country" });
            cbFilterBy.Location = new System.Drawing.Point(663, 242);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new System.Drawing.Size(94, 28);
            cbFilterBy.TabIndex = 4;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new System.Drawing.Point(21, 247);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(73, 20);
            lbSearch.TabIndex = 5;
            lbSearch.Text = "Search by";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Location = new System.Drawing.Point(591, 245);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new System.Drawing.Size(62, 20);
            lbFilter.TabIndex = 6;
            lbFilter.Text = "Filter by";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(200, 242);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(125, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Location = new System.Drawing.Point(763, 242);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new System.Drawing.Size(94, 28);
            cbFilter.TabIndex = 4;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // btnSort
            // 
            btnSort.Location = new System.Drawing.Point(763, 279);
            btnSort.Name = "btnSort";
            btnSort.Size = new System.Drawing.Size(94, 29);
            btnSort.TabIndex = 8;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // lbSort
            // 
            lbSort.AutoSize = true;
            lbSort.Location = new System.Drawing.Point(597, 283);
            lbSort.Name = "lbSort";
            lbSort.Size = new System.Drawing.Size(160, 20);
            lbSort.TabIndex = 9;
            lbSort.Text = "Sort by Member Name";
            // 
            // frmMemberManagements
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(882, 603);
            Controls.Add(lbSort);
            Controls.Add(btnSort);
            Controls.Add(txtSearch);
            Controls.Add(lbFilter);
            Controls.Add(lbSearch);
            Controls.Add(cbFilter);
            Controls.Add(cbFilterBy);
            Controls.Add(cbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(lbName);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Name = "frmMemberManagements";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagements_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.DataGridView dgvMemberList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lbSort;
    }
}
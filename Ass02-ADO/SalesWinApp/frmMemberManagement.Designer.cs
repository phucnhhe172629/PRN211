namespace SalesWinApp
{
    partial class frmMemberManagement
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
            lbCompanyName = new System.Windows.Forms.Label();
            txtCompanyName = new System.Windows.Forms.TextBox();
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
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new System.Drawing.Point(60, 100);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new System.Drawing.Size(72, 20);
            lbCompanyName.TabIndex = 0;
            lbCompanyName.Text = "Company";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new System.Drawing.Point(135, 97);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new System.Drawing.Size(254, 27);
            txtCompanyName.TabIndex = 1;
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
            dgvMemberList.Location = new System.Drawing.Point(12, 234);
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
            btnLoad.Location = new System.Drawing.Point(12, 199);
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
            btnClose.Location = new System.Drawing.Point(400, 482);
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
            // frmMemberManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new System.Drawing.Size(873, 520);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnCreate);
            Controls.Add(btnUpdate);
            Controls.Add(btnLoad);
            Controls.Add(dgvMemberList);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCountry);
            Controls.Add(txtCompanyName);
            Controls.Add(label5);
            Controls.Add(lbCompanyName);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Name = "frmMemberManagement";
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
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtCompanyName;
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
    }
}
namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            txtCarName = new System.Windows.Forms.TextBox();
            txtCarID = new System.Windows.Forms.TextBox();
            lbManufacturer = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbCarID = new System.Windows.Forms.Label();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            lbReleaseYear = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            btnLoad = new System.Windows.Forms.Button();
            btnNew = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            dgvCarList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(150, 87);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(240, 27);
            txtCarName.TabIndex = 14;
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(150, 47);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(240, 27);
            txtCarID.TabIndex = 13;
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(40, 130);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(97, 20);
            lbManufacturer.TabIndex = 12;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(40, 90);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(75, 20);
            lbCarName.TabIndex = 11;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(40, 50);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(50, 20);
            lbCarID.TabIndex = 10;
            lbCarID.Text = "Car ID";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(150, 127);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(240, 27);
            txtManufacturer.TabIndex = 15;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(535, 87);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(240, 27);
            txtReleaseYear.TabIndex = 19;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(535, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(240, 27);
            txtPrice.TabIndex = 18;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(425, 90);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(92, 20);
            lbReleaseYear.TabIndex = 17;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(425, 50);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(41, 20);
            lbPrice.TabIndex = 16;
            lbPrice.Text = "Price";
            // 
            // btnLoad
            // 
            btnLoad.Location = new System.Drawing.Point(150, 170);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new System.Drawing.Size(94, 29);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(350, 170);
            btnNew.Name = "btnNew";
            btnNew.Size = new System.Drawing.Size(94, 29);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(550, 170);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(350, 412);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(15, 205);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(800, 200);
            dgvCarList.TabIndex = 24;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(832, 453);
            Controls.Add(dgvCarList);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCarList;
    }
}
namespace SalesWinApp
{
    partial class frmMemberDetail
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
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtCompanyName = new TextBox();
            lbCompanyName = new Label();
            txtID = new TextBox();
            lbID = new Label();
            lbPassword = new Label();
            txtPassword = new TextBox();
            lbCity = new Label();
            txtCity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbCountry = new Label();
            txtCountry = new TextBox();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 27);
            txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(30, 150);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(105, 97);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(250, 27);
            txtCompanyName.TabIndex = 1;
            // 
            // lbCompanyName
            // 
            lbCompanyName.AutoSize = true;
            lbCompanyName.Location = new Point(30, 100);
            lbCompanyName.Name = "lbCompanyName";
            lbCompanyName.Size = new Size(72, 20);
            lbCompanyName.TabIndex = 3;
            lbCompanyName.Text = "Company";
            // 
            // txtID
            // 
            txtID.Location = new Point(105, 47);
            txtID.Name = "txtID";
            txtID.Size = new Size(250, 27);
            txtID.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(30, 50);
            lbID.Name = "lbID";
            lbID.Size = new Size(24, 20);
            lbID.TabIndex = 4;
            lbID.Text = "ID";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(30, 200);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(105, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 3;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(30, 250);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 2;
            lbCity.Text = "City";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(105, 247);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(250, 27);
            txtCity.TabIndex = 4;
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
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(30, 300);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 2;
            lbCountry.Text = "Country";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(105, 297);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(250, 27);
            txtCountry.TabIndex = 5;
            // 
            // frmMemberDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(387, 423);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(txtCompanyName);
            Controls.Add(lbCompanyName);
            Controls.Add(txtID);
            Controls.Add(lbID);
            Name = "frmMemberDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMemberDetails";
            Load += frmMemberDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lbCompanyName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbCountry;
        private System.Windows.Forms.TextBox txtCountry;
    }
}
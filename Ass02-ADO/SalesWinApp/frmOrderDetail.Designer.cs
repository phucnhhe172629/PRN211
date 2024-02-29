namespace SalesWinApp
{
    partial class frmOrderDetail
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
            txtOrderDate = new TextBox();
            lbOrderDate = new Label();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            txtOrderID = new TextBox();
            lbOrderID = new Label();
            lbRequiredDate = new Label();
            txtRequiredDate = new TextBox();
            lbShippedDate = new Label();
            txtShippedDate = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbFreight = new Label();
            txtFreight = new TextBox();
            lbUnitPrice = new Label();
            lbProductName = new Label();
            txtUnitPrice = new TextBox();
            lbQuantity = new Label();
            txtQuantity = new TextBox();
            lbDiscount = new Label();
            txtDiscount = new TextBox();
            cbProductName = new ComboBox();
            SuspendLayout();
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(538, 97);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(250, 27);
            txtOrderDate.TabIndex = 6;
            // 
            // lbOrderDate
            // 
            lbOrderDate.AutoSize = true;
            lbOrderDate.Location = new Point(428, 100);
            lbOrderDate.Name = "lbOrderDate";
            lbOrderDate.Size = new Size(79, 20);
            lbOrderDate.TabIndex = 2;
            lbOrderDate.Text = "OrderDate";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(140, 97);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(250, 27);
            txtMemberID.TabIndex = 1;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(30, 100);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 3;
            lbMemberID.Text = "MemberID";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(140, 47);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(250, 27);
            txtOrderID.TabIndex = 0;
            // 
            // lbOrderID
            // 
            lbOrderID.AutoSize = true;
            lbOrderID.Location = new Point(30, 50);
            lbOrderID.Name = "lbOrderID";
            lbOrderID.Size = new Size(62, 20);
            lbOrderID.TabIndex = 4;
            lbOrderID.Text = "OrderID";
            // 
            // lbRequiredDate
            // 
            lbRequiredDate.AutoSize = true;
            lbRequiredDate.Location = new Point(428, 150);
            lbRequiredDate.Name = "lbRequiredDate";
            lbRequiredDate.Size = new Size(101, 20);
            lbRequiredDate.TabIndex = 3;
            lbRequiredDate.Text = "RequiredDate";
            // 
            // txtRequiredDate
            // 
            txtRequiredDate.Location = new Point(538, 147);
            txtRequiredDate.Name = "txtRequiredDate";
            txtRequiredDate.Size = new Size(250, 27);
            txtRequiredDate.TabIndex = 7;
            // 
            // lbShippedDate
            // 
            lbShippedDate.AutoSize = true;
            lbShippedDate.Location = new Point(428, 200);
            lbShippedDate.Name = "lbShippedDate";
            lbShippedDate.Size = new Size(96, 20);
            lbShippedDate.TabIndex = 2;
            lbShippedDate.Text = "ShippedDate";
            // 
            // txtShippedDate
            // 
            txtShippedDate.Location = new Point(538, 197);
            txtShippedDate.Name = "txtShippedDate";
            txtShippedDate.Size = new Size(250, 27);
            txtShippedDate.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(253, 306);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 50);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(490, 306);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(125, 50);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbFreight
            // 
            lbFreight.AutoSize = true;
            lbFreight.Location = new Point(428, 49);
            lbFreight.Name = "lbFreight";
            lbFreight.Size = new Size(55, 20);
            lbFreight.TabIndex = 2;
            lbFreight.Text = "Freight";
            // 
            // txtFreight
            // 
            txtFreight.Location = new Point(538, 46);
            txtFreight.Name = "txtFreight";
            txtFreight.Size = new Size(250, 27);
            txtFreight.TabIndex = 5;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Location = new Point(30, 201);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(68, 20);
            lbUnitPrice.TabIndex = 3;
            lbUnitPrice.Text = "UnitPrice";
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Location = new Point(30, 151);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(100, 20);
            lbProductName.TabIndex = 2;
            lbProductName.Text = "ProductName";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(140, 198);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(250, 27);
            txtUnitPrice.TabIndex = 3;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Location = new Point(30, 251);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(65, 20);
            lbQuantity.TabIndex = 2;
            lbQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(140, 248);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 27);
            txtQuantity.TabIndex = 4;
            // 
            // lbDiscount
            // 
            lbDiscount.AutoSize = true;
            lbDiscount.Location = new Point(428, 251);
            lbDiscount.Name = "lbDiscount";
            lbDiscount.Size = new Size(67, 20);
            lbDiscount.TabIndex = 2;
            lbDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(538, 248);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(250, 27);
            txtDiscount.TabIndex = 9;
            // 
            // cbProductName
            // 
            cbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductName.FormattingEnabled = true;
            cbProductName.Location = new Point(140, 148);
            cbProductName.Name = "cbProductName";
            cbProductName.Size = new Size(250, 28);
            cbProductName.TabIndex = 2;
            cbProductName.SelectedIndexChanged += cbProductID_SelectedIndexChanged;
            // 
            // frmOrderDetail
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(814, 368);
            Controls.Add(cbProductName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDiscount);
            Controls.Add(lbDiscount);
            Controls.Add(txtFreight);
            Controls.Add(lbFreight);
            Controls.Add(txtQuantity);
            Controls.Add(txtShippedDate);
            Controls.Add(lbQuantity);
            Controls.Add(lbShippedDate);
            Controls.Add(txtOrderDate);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtRequiredDate);
            Controls.Add(lbProductName);
            Controls.Add(lbUnitPrice);
            Controls.Add(lbOrderDate);
            Controls.Add(lbRequiredDate);
            Controls.Add(txtMemberID);
            Controls.Add(lbMemberID);
            Controls.Add(txtOrderID);
            Controls.Add(lbOrderID);
            Name = "frmOrderDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmOrderDetail";
            Load += frmOrderDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.TextBox txtRequiredDate;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtShippedDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.TextBox txtFreight;
        private Label lbUnitPrice;
        private Label lbProductName;
        private TextBox txtUnitPrice;
        private Label lbQuantity;
        private TextBox txtQuantity;
        private Label lbDiscount;
        private TextBox txtDiscount;
        private ComboBox cbProductName;
    }
}
﻿namespace SalesWinApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            managementMemberToolStripMenuItem = new ToolStripMenuItem();
            managementOrderToolStripMenuItem = new ToolStripMenuItem();
            managementProductToolStripMenuItem = new ToolStripMenuItem();
            tsmMember = new ToolStripMenuItem();
            tsmOrder = new ToolStripMenuItem();
            tsmProduct = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, tsmMember, tsmOrder, tsmProduct, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(645, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { managementMemberToolStripMenuItem, managementOrderToolStripMenuItem, managementProductToolStripMenuItem });
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(64, 24);
            homeToolStripMenuItem.Text = "Home";
            // 
            // managementMemberToolStripMenuItem
            // 
            managementMemberToolStripMenuItem.Name = "managementMemberToolStripMenuItem";
            managementMemberToolStripMenuItem.Size = new Size(240, 26);
            managementMemberToolStripMenuItem.Text = "Management Member";
            // 
            // managementOrderToolStripMenuItem
            // 
            managementOrderToolStripMenuItem.Name = "managementOrderToolStripMenuItem";
            managementOrderToolStripMenuItem.Size = new Size(240, 26);
            managementOrderToolStripMenuItem.Text = "Management Order";
            // 
            // managementProductToolStripMenuItem
            // 
            managementProductToolStripMenuItem.Name = "managementProductToolStripMenuItem";
            managementProductToolStripMenuItem.Size = new Size(240, 26);
            managementProductToolStripMenuItem.Text = "Management Product";
            // 
            // tsmMember
            // 
            tsmMember.Name = "tsmMember";
            tsmMember.Size = new Size(171, 24);
            tsmMember.Text = "Management Member";
            tsmMember.Click += tsmMember_Click;
            // 
            // tsmOrder
            // 
            tsmOrder.Name = "tsmOrder";
            tsmOrder.Size = new Size(153, 24);
            tsmOrder.Text = "Management Order";
            tsmOrder.Click += tsmOrder_Click;
            // 
            // tsmProduct
            // 
            tsmProduct.Name = "tsmProduct";
            tsmProduct.Size = new Size(166, 24);
            tsmProduct.Text = "Management Product";
            tsmProduct.Click += tsmProduct_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(70, 24);
            logOutToolStripMenuItem.Text = "Logout";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(28, 56);
            label1.Name = "label1";
            label1.Size = new Size(581, 81);
            label1.TabIndex = 1;
            label1.Text = "Welcome to FStore";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 164);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmMember;
        private System.Windows.Forms.ToolStripMenuItem tsmOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmProduct;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}
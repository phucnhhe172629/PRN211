namespace Giai_PT_bac_2___Win_form
{
    partial class frmGiaiPTBac2
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
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(30, 50);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(80, 47);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(150, 22);
            this.txtA.TabIndex = 0;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(30, 100);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 16);
            this.lblB.TabIndex = 0;
            this.lblB.Text = "B";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(80, 97);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(150, 22);
            this.txtB.TabIndex = 1;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(30, 150);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(16, 16);
            this.lblC.TabIndex = 0;
            this.lblC.Text = "C";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(80, 147);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(150, 22);
            this.txtC.TabIndex = 2;
            // 
            // btnCal
            // 
            this.btnCal.Location = new System.Drawing.Point(15, 200);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(60, 25);
            this.btnCal.TabIndex = 3;
            this.btnCal.Text = "&Cal";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 200);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(180, 200);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 25);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(33, 238);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(44, 16);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label1";
            // 
            // frmGiaiPTBac2
            // 
            this.AcceptButton = this.btnCal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(282, 278);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGiaiPTBac2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giai PT Bac 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
    }
}


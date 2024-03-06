namespace DemoCallAPI
{
    partial class Form1
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
            button1 = new Button();
            label1 = new Label();
            txtWeatherForecast = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(215, 212);
            button1.Name = "button1";
            button1.Size = new Size(133, 66);
            button1.TabIndex = 0;
            button1.Text = "Call API";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 70);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Result";
            // 
            // txtWeatherForecast
            // 
            txtWeatherForecast.Location = new Point(127, 24);
            txtWeatherForecast.Name = "txtWeatherForecast";
            txtWeatherForecast.Size = new Size(387, 164);
            txtWeatherForecast.TabIndex = 3;
            txtWeatherForecast.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 290);
            Controls.Add(txtWeatherForecast);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RichTextBox txtWeatherForecast;
    }
}

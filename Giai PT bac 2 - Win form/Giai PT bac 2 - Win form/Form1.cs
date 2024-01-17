using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giai_PT_bac_2___Win_form
{
    public partial class frmGiaiPTBac2 : Form
    {
        public frmGiaiPTBac2()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            // chuyen doi du lieu
            double a = Double.Parse(txtA.Text);
            double b = Double.Parse(txtB.Text);
            double c = Double.Parse(txtC.Text);
            // tinh toan Delta
            double delta = b * b - 4 * a * c;
            // kiem tra
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                lblResult.Text = "PT co 2 No phan biet : x1 = " + x1 + " x2 = " + x2;
            }
            else if (delta < 0)
            {
                lblResult.Text = "PTVN";
            }
            else
            {
                lblResult.Text = "PT co 1 No = " + (-b / (2 * a));
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";// gan bang rong
            txtB.Clear();// dung ham
            txtC.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);// thoat chuong trinh
        }
    }
}

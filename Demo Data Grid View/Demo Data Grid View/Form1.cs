using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Data_Grid_View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDataTable_Click(object sender, EventArgs e)
        {
            DataTable products = new DataTable();
            // them cot cho data table
            products.Columns.Add("ProductID", typeof(int));
            products.Columns.Add("ProductName", typeof(string));
            products.Columns.Add("UnitPrice", typeof(decimal));
            //them du lieu
            products.Rows.Add(1, "Java", 99.9);
            products.Rows.Add(2, "C#", 80);
            products.Rows.Add(3, "HTML", 60);
            // binding vao data grid view
            dgvProducts.DataSource = products;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<dynamic> products = new List<dynamic> {
            new { productID = 1,ProductName="C++",UnitPrice=67},
            new { productID = 2,ProductName="DSA",UnitPrice=88}
            };
            // them no vao gridview
            dgvProducts.DataSource = products;
        }
    }
}

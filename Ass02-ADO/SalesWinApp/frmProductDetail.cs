using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductDetail : Form
    {
        public frmProductDetail()
        {
            InitializeComponent();
        }

        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False: Insert - True: Update
        public Product ProductInfo { get; set; }

        // Load Form
        private void frmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = false;
            // Update mode
            if (InsertOrUpdate == true)
            {
                // Show Product to perform updating
                txtProductID.Text = ProductInfo.ProductId.ToString();
                txtCategoryID.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName;
                txtWeight.Text = ProductInfo.Weight;
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
            }

        }

        // Save function
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate == false)
                {
                    var Product = new Product()
                    {
                        CategoryId = int.Parse(txtCategoryID.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    };
                    ProductRepository.InsertProduct(Product);
                }
                else
                {
                    var Product = new Product()
                    {
                        ProductId = int.Parse(txtProductID.Text),
                        CategoryId = int.Parse(txtCategoryID.Text),
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    };
                    ProductRepository.UpdateProduct(Product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel function
        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
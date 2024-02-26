using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmProductManagement : Form
    {
        IProductRepository ProductRepository = new ProductRepository();
        //create data source
        BindingSource source;
        public frmProductManagement()
        {
            InitializeComponent();
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            //Register this event to open the frmProductDetail form that performs updating
            dgvProductList.CellDoubleClick += dgvProduct_CellDoubleClick;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProduct(),
                ProductRepository = ProductRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(ProductRepository.GetProducts());
                //set focus Product updated
                source.Position = GetProduct().ProductId - 1;
            }
        }

        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
        }

        private Product GetProduct()
        {
            Product Product = null;
            try
            {
                Product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return Product;
        }

        private void LoadProductList(IEnumerable<Product> ProductList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = ProductList;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategoryID.DataBindings.Add("Text", source, "CategoryID");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", source, "UnitsInStock");

                dgvProductList.DataSource = null;
                dgvProductList.DataSource = source;

                txtProductID.Enabled = false;

                if (ProductList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Product List");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e) => LoadProductList(ProductRepository.GetProducts().OrderBy(p => p.ProductId));

        private void btnClose_Click(object sender, EventArgs e)=> Close();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Add Product",
                InsertOrUpdate = false,
                ProductRepository = ProductRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(ProductRepository.GetProducts());
                //Set focus Product inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Product = GetProduct();
                ProductRepository.DeleteProduct(Product.ProductId);
                LoadProductList(ProductRepository.GetProducts());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Product");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmProductDetail frmProductDetail = new frmProductDetail
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                ProductInfo = GetProduct(),
                ProductRepository = ProductRepository
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductList(ProductRepository.GetProducts());
                //set focus Product updated
                source.Position = source.Position ;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cbSearch.Text.Equals("Name"))
            {
                LoadProductList(ProductRepository.GetProductListByName(txtSearch.Text));
            }
            if (cbSearch.Text.Equals("ID"))
            {
                LoadProductList(ProductRepository.GetProductListById(txtSearch.Text));
            }
            if (cbSearch.Text.Equals("Unit Price"))
            {
                LoadProductList(ProductRepository.GetProductListByUnitPrice(Int32.Parse(txtSearch.Text)));
            }
            if (cbSearch.Text.Equals("Units In Stock"))
            {
                LoadProductList(ProductRepository.GetProductListByUnitInStock(Int32.Parse(txtSearch.Text)));
            }
        }
    }
}

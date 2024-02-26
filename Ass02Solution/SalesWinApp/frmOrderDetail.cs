using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmOrderDetail : Form
    {
        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public IProductRepository ProductRepository = new ProductRepository();
        public IOrderRepository OrderRepository { get; set; }
        public IOrderDetailRepository OrderDetailRepository { get; set; }
        public bool InsertOrUpdate { get; set; } // False: Insert - True: Update
        public Order OrderInfo { get; set; }
        public OrderDetail OrderDetailInfo { get; set; }
        public Boolean isAdmin { get; set; }

        // Load Form
        private void frmOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;
            txtUnitPrice.Enabled = false;

            List<String> ProductList = ProductRepository.GetProducts().Select(p => p.ProductName).ToList();
            cbProductName.Items.Clear();
            cbProductName.Items.AddRange(ProductList.ToArray());

            if (InsertOrUpdate == true)
            {
                txtOrderID.Text = OrderInfo.OrderId.ToString();
                txtMemberID.Text = OrderInfo.MemberId.ToString();
                txtOrderDate.Text = OrderInfo.OrderDate.ToString();
                txtRequiredDate.Text = OrderInfo.RequiredDate.ToString();
                txtShippedDate.Text = OrderInfo.ShippedDate.ToString();
                txtFreight.Text = OrderInfo.Freight.ToString();

                txtUnitPrice.Text = OrderDetailInfo.UnitPrice.ToString();
                txtQuantity.Text = OrderDetailInfo.Quantity.ToString();
                txtDiscount.Text = OrderDetailInfo.Discount.ToString();
                cbProductName.SelectedItem = cbProductName.Items.Cast<object>()
                    .FirstOrDefault(i => i.Equals(ProductRepository.GetProductByID(OrderDetailInfo.ProductId).ProductName));
            }
        }

        // Save function
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate == false)
                {
                    var Order = new Order()
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                        OrderDate = DateTime.Parse(txtOrderDate.Text),
                        RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    OrderRepository.InsertOrder(Order);
                    var OrderDetail = new OrderDetail()
                    {
                        OrderId = Order.OrderId,
                        ProductId = ProductRepository.GetProductIdByName(cbProductName.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Discount = double.Parse(txtDiscount.Text),
                    };
                    OrderDetailRepository.InsertOrderDetail(OrderDetail);
                }
                else
                {
                    var Order = new Order()
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        MemberId = int.Parse(txtMemberID.Text),
                        OrderDate = DateTime.Parse(txtOrderDate.Text),
                        RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Freight = decimal.Parse(txtFreight.Text),
                    };
                    OrderRepository.UpdateOrder(Order);
                    var OrderDetail = new OrderDetail()
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        ProductId = ProductRepository.GetProductIdByName(cbProductName.Text),
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        Discount = double.Parse(txtDiscount.Text),
                    };
                    OrderDetailRepository.UpdateOrderDetail(OrderDetail);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cancel function
        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUnitPrice.Text = ProductRepository.GetProductByID(ProductRepository.GetProductIdByName(cbProductName.Text)).UnitPrice.ToString();
        }
    }
}
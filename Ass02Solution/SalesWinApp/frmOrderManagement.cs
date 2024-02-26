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
    public partial class frmOrderManagement : Form
    {
        IOrderRepository OrderRepository = new OrderRepository();
        IOrderDetailRepository OrderDetailRepository = new OrderDetailRepository();
        //create data source
        BindingSource source;
        public IMemberRepository MemberRepository { get; set; }
        public Member MemberInfo { get; set; }
        public Boolean isAdmin { get; set; }
        public frmOrderManagement()
        {
            InitializeComponent();
        }

        private void frmOrderManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            if (!isAdmin)
            {
                btnCreate.Enabled = false;
            }
            //Register this event to open the frmOrderDetail form that performs updating
            dgvOrderList.CellDoubleClick += dgvOrder_CellDoubleClick;
        }

        private void dgvOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                isAdmin = isAdmin,
                OrderInfo = GetOrder(),
                OrderDetailInfo = GetOrderDetail(),
                OrderRepository = OrderRepository,
                OrderDetailRepository = OrderDetailRepository,
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList(OrderRepository.GetOrders());
                //set focus Order updated
                source.Position = GetOrder().OrderId - 1;
            }
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
        }

        private Order GetOrder()
        {
            Order Order = null;
            try
            {
                Order = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return Order;
        }

        private OrderDetail GetOrderDetail()
        {
            OrderDetail OrderDetail = null;
            try
            {
                OrderDetail = OrderDetailRepository.GetOrderDetailByID(int.Parse(txtOrderID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Order");
            }
            return OrderDetail;
        }

        private void LoadOrderList(IEnumerable<Order> OrderList)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = OrderList;

                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderId");
                txtMemberID.DataBindings.Add("Text", source, "MemberId");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = source;
                dgvOrderList.Columns["Member"].Visible = false;

                txtOrderID.Enabled = false;
                if (OrderList.Count() == 0)
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
                MessageBox.Show(ex.Message, "Load Order List");
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                LoadOrderList(OrderRepository.GetOrders().OrderBy(o => o.OrderId));
            }
            else
            {
                LoadOrderList(OrderRepository.GetOrdersByMemberId(MemberInfo.MemberId).OrderBy(o => o.OrderId));
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Add Order",
                InsertOrUpdate = false,
                OrderRepository = OrderRepository,
                OrderDetailRepository = OrderDetailRepository,
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList(OrderRepository.GetOrders());
                //Set focus Order inserted
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Order = GetOrder();
                OrderRepository.DeleteOrder(Order.OrderId);
                var OrderDetail = GetOrderDetail();
                OrderDetailRepository.DeleteOrderDetail(OrderDetail.OrderId);
                LoadOrderList(OrderRepository.GetOrders());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmOrderDetail frmOrderDetail = new frmOrderDetail
            {
                Text = "Update Order",
                InsertOrUpdate = true,
                isAdmin = isAdmin,
                OrderInfo = GetOrder(),
                OrderDetailInfo = GetOrderDetail(),
                OrderRepository = OrderRepository,
                OrderDetailRepository = OrderDetailRepository
            };
            if (frmOrderDetail.ShowDialog() == DialogResult.OK)
            {
                LoadOrderList(OrderRepository.GetOrders());
                //set focus Order updated
                source.Position = source.Position ;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {

        public void InsertOrder(Order Order) => OrderDAO.Instance.AddNew(Order);

        public void UpdateOrder(Order Order) => OrderDAO.Instance.Update(Order);

        public List<Order> GetOrdersByBillID(int billId) => OrderDAO.Instance.GetOrdersByBillID(billId);

        public Order GetOrderByID(int billId, int productId) => OrderDAO.Instance.GetOrderByID(billId, productId);

        public void DeleOrdersByBill(int billId) => OrderDAO.Instance.RemoveList(billId);

        public void DeleteOrder(int billId, int productId) => OrderDAO.Instance.Remove(billId, productId);

        public List<Order> GetOrderList() => OrderDAO.Instance.GetOrderList();

        public void Completed(int billId) => OrderDAO.Instance.Completed(billId);
    }
}

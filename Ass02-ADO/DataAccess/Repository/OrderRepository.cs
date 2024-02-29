using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(int Id) => OrderDAO.Instance.Remove(Id);

        public Order GetOrderByID(int Id) => OrderDAO.Instance.GetOrderByID(Id);

        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();

        public IEnumerable<Order> GetOrdersByMemberId(int MemberId) => OrderDAO.Instance.GetOrderListByMemberId(MemberId);

        public void InsertOrder(Order order) => OrderDAO.Instance.AddNew(order);

        public IEnumerable<Order> SearchByOrderDate(DateTime date1, DateTime date2) => OrderDAO.Instance.SearchByOrderDate(date1, date2);

        public void UpdateOrder(Order order) => OrderDAO.Instance.Update(order);
    }
}

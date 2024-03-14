using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrdersByMemberId(int MemberId);
        Order GetOrderByID(int Id);
        void InsertOrder(Order order);
        void DeleteOrder(int Id);
        void UpdateOrder(Order order);
        IEnumerable<Order> SearchByOrderDate(DateTime date1, DateTime date2);
    }
}

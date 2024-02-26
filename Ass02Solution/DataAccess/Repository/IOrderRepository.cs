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
        Order GetOrderByID(int Id);
        void InsertOrder(Order order);
        void DeleteOrder(int Id);
        void UpdateOrder(Order order);
    }
}

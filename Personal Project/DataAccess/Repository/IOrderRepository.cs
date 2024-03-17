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
        List<Order> GetNewOrders();
        List<Order> GetOrdersByBillID(int billId);
        Order GetOrderByID(int billId, int productId);
        void InsertOrder(Order order);
        void DeleteOrder(int billId, int productId);
        void UpdateOrder(Order order);
        void DeleOrdersByBill(int billId);
    }
}

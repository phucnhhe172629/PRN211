using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByID(int Id);
        void InsertOrderDetail(OrderDetail OrderDetail);
        void DeleteOrderDetail(int Id);
        void UpdateOrderDetail(OrderDetail OrderDetail);
    }
}

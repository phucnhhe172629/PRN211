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
        IEnumerable<OrderDetail> GetOrderDetailListByID(int Id);
        OrderDetail GetOrderDetailByID(int oid, int pid);
        void InsertOrderDetail(OrderDetail OrderDetail);
        void DeleteOrderDetail(int oid, int pid);
        void DeleteOrderDetailList(int oid);
        void UpdateOrderDetail(OrderDetail OrderDetail);
    }
}

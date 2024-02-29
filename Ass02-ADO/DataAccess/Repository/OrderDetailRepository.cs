using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(int Id) => OrderDetailDAO.Instance.Remove(Id);

        public OrderDetail GetOrderDetailByID(int Id) => OrderDetailDAO.Instance.GetOrderDetailByID(Id);

        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();

        public void InsertOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.AddNew(OrderDetail);

        public void UpdateOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.Update(OrderDetail);
    }
}

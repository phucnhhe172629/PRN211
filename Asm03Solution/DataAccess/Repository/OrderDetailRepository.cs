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
        public IEnumerable<OrderDetail> GetOrderDetailListByID(int Id) => OrderDetailDAO.Instance.GetOrderDetailListByID(Id);
        public void DeleteOrderDetail(int oid, int pid) => OrderDetailDAO.Instance.Remove(oid, pid);

        public OrderDetail GetOrderDetailByID(int oid, int pid) => OrderDetailDAO.Instance.GetOrderDetailByID(oid, pid);

        public void InsertOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.AddNew(OrderDetail);

        public void UpdateOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.Update(OrderDetail);

        public void DeleteOrderDetailList(int oid) => OrderDetailDAO.Instance.RemoveList(oid);
    }
}

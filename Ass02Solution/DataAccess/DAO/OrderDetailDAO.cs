using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class OrderDetailDAO : FStoreContext
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList() => OrderDetails.ToList();
        public OrderDetail GetOrderDetailByID(int id) => OrderDetails.SingleOrDefault(o => o.OrderId == id);
        public void AddNew(OrderDetail orderDetail)
        {
            OrderDetails.Add(orderDetail);
            SaveChanges();
        }

        public void Update(OrderDetail orderDetail)
        {
            OrderDetails.Update(orderDetail);
            SaveChanges();
        }

        public void Remove(int id)
        {
            OrderDetails.Remove(GetOrderDetailByID(id));
            SaveChanges();
        }
    }
}

using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO : FStoreContext
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            using FStoreContext context = new FStoreContext();
            return context.Orders.ToList();
        }
        public Order GetOrderByID(int id) => Orders.SingleOrDefault(m => m.OrderId == id);
        public void AddNew(Order order)
        {
            Orders.Add(order);
            SaveChanges();
        }

        public void Update(Order order)
        {
            Orders.Update(order);
            SaveChanges();
        }

        public void Remove(int id)
        {
            Orders.Remove(GetOrderByID(id));
            SaveChanges();
        }
    }
}

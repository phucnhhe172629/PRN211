using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class OrderDetailDAO : EStoreContext
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
        public List<OrderDetail> GetOrderDetailListByID(int id)
        {
            List<OrderDetail> orderDetail = null;
            try
            {
                using var context = new EStoreContext();
                orderDetail = context.OrderDetails.ToList().FindAll(m => m.OrderId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        public OrderDetail GetOrderDetailByID(int oid, int pid)
        {
            OrderDetail orderDetail = null;
            try
            {
                using var context = new EStoreContext();
                orderDetail = context.OrderDetails.SingleOrDefault(m => m.OrderId == oid && m.ProductId == pid);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetail;
        }

        public void AddNew(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail _orderDetail = GetOrderDetailByID(orderDetail.OrderId, orderDetail.ProductId);
                if (_orderDetail == null)
                {
                    using var context = new EStoreContext();
                    context.OrderDetails.Add(_orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("OrderDetail is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(OrderDetail orderDetail)
        {
            try
            {
                OrderDetail _orderDetail = GetOrderDetailByID(orderDetail.OrderId, orderDetail.ProductId);
                if (_orderDetail != null)
                {
                    using var context = new EStoreContext();
                    context.OrderDetails.Update(_orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("OrderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int oid, int pid)
        {
            try
            {
                OrderDetail orderDetail = GetOrderDetailByID(oid, pid);
                if (orderDetail != null)
                {
                    using var context = new EStoreContext();
                    context.OrderDetails.Remove(orderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("OrderDetail does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveList(int oid)
        {
            try
            {
                List<OrderDetail> orderDetail = GetOrderDetailListByID(oid);
                using var context = new EStoreContext();
                foreach (var item in orderDetail)
                {
                    context.OrderDetails.Remove(item);

                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

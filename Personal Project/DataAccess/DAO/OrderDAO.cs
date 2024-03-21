using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO
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

        public Order GetOrderByID(int billId, int productId)
        {
            Order order = null;
            try
            {
                using var context = new PRNProjectContext();
                order = context.Orders.SingleOrDefault(c => c.BillId == billId && c.ProductId == productId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public List<Order> GetOrdersByBillID(int billId)
        {
            List<Order> orders = null;
            try
            {
                using var context = new PRNProjectContext();
                orders = context.Orders.ToList().FindAll(c => c.BillId == billId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public List<Order> GetOrderList()
        {
            List<Order> orders = null;
            try
            {
                using var context = new PRNProjectContext();
                orders = context.Orders.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        // Add new a Order
        public void AddNew(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.BillId, order.ProductId);
                if (_order == null)
                {
                    using var context = new PRNProjectContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Update a Order
        public void Update(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.BillId, order.ProductId);
                if (_order != null)
                {
                    using var context = new PRNProjectContext();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // Remove a Order
        public void Remove(int billId, int productId)
        {
            try
            {
                Order order = GetOrderByID(billId, productId);
                if (order != null)
                {
                    using var context = new PRNProjectContext();
                    order.Status = "Hủy";
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveList(int billId)
        {
            try
            {
                List<Order> order = GetOrdersByBillID(billId);
                using var context = new PRNProjectContext();
                foreach (var item in order)
                {
                    item.Status = "Hủy theo đơn";
                    context.Orders.Update(item);
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Completed(int billId)
        {
            try
            {
                List<Order> order = GetOrdersByBillID(billId);
                using var context = new PRNProjectContext();
                foreach (var item in order)
                {
                    item.Status = "Hoàn thành";
                    context.Orders.Update(item);
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

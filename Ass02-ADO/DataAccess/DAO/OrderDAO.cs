﻿using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class OrderDAO : DBContext
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
            string sql = "select * from [Order]";
            var orderList = new List<Order>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                Order order = new Order
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = decimal.Parse(dr["Freight"].ToString()),
                };
                orderList.Add(order);
            }
            return orderList;
        }
        public IEnumerable<Order> GetOrderListByMemberId(int MemberId)
        {
            string sql = "select * from [Order] where MemberId = @MemberId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@MemberId", MemberId));
            var orderList = new List<Order>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                Order order = new Order
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = decimal.Parse(dr["Freight"].ToString()),
                };
                orderList.Add(order);
            }
            return orderList;
        }
        public Order GetOrderByID(int id)
        {
            string sql = "select * from [Order] where OrderId = @OrderId";
            DataTable dt = DBContext.GetDataBySQL(sql, new SqlParameter("@OrderId", id));
            Order orderObject = null;
            foreach (DataRow dr in dt.Rows)
            {
                orderObject = new Order
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = decimal.Parse(dr["Freight"].ToString()),
                };
            }
            return orderObject;
        }

        public void AddNew(Order order)
        {
            string sql = "insert into [Order] values ( @MemberId, @OrderDate, @RequiredDate, @ShippedDate, @Freight); SELECT SCOPE_IDENTITY()";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberId", order.MemberId),
                new SqlParameter("@OrderDate", order.OrderDate),
                new SqlParameter("@RequiredDate", order.RequiredDate),
                new SqlParameter("@ShippedDate", order.ShippedDate),
                new SqlParameter("@Freight", order.Freight),
            };
            DBContext.ExcuteSql(sql, parameters);
        }

        public void Update(Order order)
        {
            string sql = "update [Order] SET MemberId = @MemberId, OrderDate = @OrderDate, RequiredDate = @RequiredDate, ShippedDate = @ShippedDate, Freight = @Freight WHERE OrderId = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MemberId", order.MemberId),
                new SqlParameter("@OrderDate", order.OrderDate),
                new SqlParameter("@RequiredDate", order.RequiredDate),
                new SqlParameter("@ShippedDate", order.ShippedDate),
                new SqlParameter("@Freight", order.Freight),
                new SqlParameter("@OrderId", order.OrderId)
            };
            DBContext.ExcuteSql(sql, parameters);
        }

        public void Remove(int id)
        {
            string sql = "delete from [Order] where OrderId = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", id),
            };
            DBContext.ExcuteSql(sql, parameters);
        }

        public List<Order> SearchByOrderDate(DateTime date1, DateTime date2)
        {
            string sql = "select * from [Order] where OrderDate between @date1 and @date2";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@date1", date1),
                new SqlParameter("@date2", date2),
            };
            var orderList = new List<Order>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, parameters).Rows)
            {
                Order order = new Order
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    MemberId = int.Parse(dr["MemberId"].ToString()),
                    OrderDate = DateTime.Parse(dr["OrderDate"].ToString()),
                    RequiredDate = DateTime.Parse(dr["RequiredDate"].ToString()),
                    ShippedDate = DateTime.Parse(dr["ShippedDate"].ToString()),
                    Freight = decimal.Parse(dr["Freight"].ToString()),
                };
                orderList.Add(order);
            }
            return orderList;
        }
    }
}

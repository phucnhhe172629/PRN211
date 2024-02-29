using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    internal class OrderDetailDAO : DBContext
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

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            string sql = "select * from OrderDetail";
            var orderDetailList = new List<OrderDetail>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString()),
                    Discount = double.Parse(dr["Discount"].ToString())
                };
                orderDetailList.Add(orderDetail);
            }
            return orderDetailList;
        }

        public OrderDetail GetOrderDetailByID(int id)
        {
            string sql = "select * from OrderDetail where OrderId = @OrderId";
            OrderDetail orderDetail = null;
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@OrderId", id)).Rows)
            {
                orderDetail = new OrderDetail
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString()),
                    Discount = double.Parse(dr["Discount"].ToString())
                };
            }
            return orderDetail;
        }

        public void AddNew(OrderDetail orderDetail)
        {
            string sql = "insert into OrderDetail values(@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderDetail.OrderId),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@UnitPrice", orderDetail.UnitPrice),
                new SqlParameter("@Quantity", orderDetail.Quantity),
                new SqlParameter("@Discount", orderDetail.Discount)
            };
            DBContext.ExcuteSql(sql, parameters);
        }

        public void Update(OrderDetail orderDetail)
        {
            string sql = "update OrderDetail SET ProductId = @ProductId, UnitPrice = @UnitPrice, Quantity = @Quantity, Discount = @Discount WHERE OrderId = @OrderId";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderDetail.OrderId),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@UnitPrice", orderDetail.UnitPrice),
                new SqlParameter("@Quantity", orderDetail.Quantity),
                new SqlParameter("@Discount", orderDetail.Discount)
            };
            DBContext.ExcuteSql(sql, parameters);
        }

        public void Remove(int id)
        {
            string sql = "delete from OrderDetail where OrderId = @OrderId";
            DBContext.ExcuteSql(sql, new SqlParameter("@OrderId", id));
        }
    }
}

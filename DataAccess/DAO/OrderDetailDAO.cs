using Azure.Core;
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
    public class OrderDetailDAO
    {
       
        private static OrderDetailDAO instance;
        private static readonly object instanceLock = new object();
        public OrderDetailDAO() { }

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

        public List<OrderDetailObject> GetOrderDetail()
        {
            string sql = "select * from OrderDetails";
            var orderDetailList = new List<OrderDetailObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql).Rows)
            {
                OrderDetailObject orderDetail = new OrderDetailObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString()),
                    Discount = decimal.Parse(dr["Discount"].ToString())
                };
                orderDetailList.Add(orderDetail);
            }
            return orderDetailList;
        }

        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId)
        {
            string sql = "select * from OrderDetails where OrderId = @OrderId";
            var orderDetailList = new List<OrderDetailObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@OrderId", orderId)).Rows)
            {
                OrderDetailObject orderDetail = new OrderDetailObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString()),
                    Discount = decimal.Parse(dr["Discount"].ToString())
                };
                orderDetailList.Add(orderDetail);
            }
            return orderDetailList;
        }

        public int Delete(int id)
        {
            string sql = "delete from OrderDetails where OrderId = @OrderId";
            return DBContext.ExcuteSql(sql, new SqlParameter("@OrderId", id));
        }

        public int Insert(OrderDetailObject orderDetail)
        {
            string sql = "insert into OrderDetails values(@OrderId, @ProductId, @UnitPrice, @Quantity, @Discount)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@OrderId", orderDetail.OrderId),
                new SqlParameter("@ProductId", orderDetail.ProductId),
                new SqlParameter("@UnitPrice", orderDetail.UnitPrice),
                new SqlParameter("@Quantity", orderDetail.Quantity),
                new SqlParameter("@Discount", orderDetail.Discount)
            };
            return DBContext.ExcuteSql(sql, parameters);
        }

        public List<OrderDetailObject> GetOrderDetailByMemberId(int memberId)
        {
            string sql = "select * from OrderDetails where OrderId in (select OrderId from [Order] where MemberId = @MemberId)";
            var orderDetailList = new List<OrderDetailObject>();
            foreach (DataRow dr in DBContext.GetDataBySQL(sql, new SqlParameter("@MemberId", memberId)).Rows)
            {
                OrderDetailObject orderDetail = new OrderDetailObject
                {
                    OrderId = int.Parse(dr["OrderId"].ToString()),
                    ProductId = int.Parse(dr["ProductId"].ToString()),
                    UnitPrice = decimal.Parse(dr["UnitPrice"].ToString()),
                    Quantity = int.Parse(dr["Quantity"].ToString()),
                    Discount = decimal.Parse(dr["Discount"].ToString())
                };
                orderDetailList.Add(orderDetail);
            }
            return orderDetailList;
        }
    }
}

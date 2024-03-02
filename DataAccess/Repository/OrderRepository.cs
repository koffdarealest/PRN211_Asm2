using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Delete(int orderId)
        {
            OrderDAO.Instance.DeleteOrder(orderId);
        }

        public OrderObject GetOrderById(int orderId)
        {
            return OrderDAO.Instance.GetOrderById(orderId);
        }

        public List<OrderObject> GetOrders()
        {
            return OrderDAO.Instance.GetAllOrder();
        }

        public string GetTotalOrderByID(string v)
        {
            return OrderDAO.Instance.GetTotalOrderByID(v);
        }

        public void Insert(OrderObject orderObject)
        {
            OrderDAO.Instance.InsertOrder(orderObject);
        }

        public int InsertAndGetOrderId(OrderObject orderObject)
        {
            return OrderDAO.Instance.InsertAndGetOrderId(orderObject);
        }

        public List<OrderObject> SearchByOrderDate(DateTime date1, DateTime date2)
        {
            return OrderDAO.Instance.SearchByOrderDate(date1, date2);
        }
    }
}

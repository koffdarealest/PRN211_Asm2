using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        List<OrderObject> GetOrders();
        OrderObject GetOrderById(int orderId);
        void Insert(OrderObject orderObject);
        void Delete(int orderId);
        int InsertAndGetOrderId(OrderObject orderObject);
        string GetTotalOrderByID(string v);
        List<OrderObject> SearchByOrderDate(DateTime date1, DateTime date2);
    }
}

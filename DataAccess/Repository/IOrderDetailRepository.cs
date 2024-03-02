using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetailObject> GetOrderDetail();
        List<OrderDetailObject> GetOrderDetailByOrderId(int orderId);
        void Delete(int orderId);
        void Insert(OrderDetailObject orderDetailObject);
        List<OrderDetailObject> GetOrderDetailByMemberId(int memberId);
    }
}


using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void Delete(int orderId)
        {
            OrderDetailDAO.Instance.Delete(orderId);
        }

        public List<OrderDetailObject> GetOrderDetailByOrderId(int orderId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByOrderId(orderId);
        }

        public List<OrderDetailObject> GetOrderDetail()
        {
            return OrderDetailDAO.Instance.GetOrderDetail();
        }

        public void Insert(OrderDetailObject orderDetailObject)
        {
            OrderDetailDAO.Instance.Insert(orderDetailObject);
        }
        public List<OrderDetailObject> GetOrderDetailByMemberId(int memberId)
        {
            return OrderDetailDAO.Instance.GetOrderDetailByMemberId(memberId);
        }
    }
}

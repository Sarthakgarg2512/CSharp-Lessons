using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NuGet.Protocol.Core.Types;
using System.Security.Policy;

namespace NWind.Models
{
    public class RepositoryOrders
    {
            public NorthwindContext _context;
            public RepositoryOrders(NorthwindContext context)
            {
                _context = context;
            }
            public List<int> GetOrders()
            {
                List<int> OrdfersIds = (from o in _context.Orders select o.OrderId).ToList();
                return OrdfersIds;
            }
        public Order FindOrderById(int id)
        {
            Order order = _context.Orders.Find(id);
                return order;
        }
        public List<Order> FindOrderByCustomerID(string customerID)
        {
            List<Order> customerorders = (from o in _context.Orders where o.CustomerId == customerID select o).ToList();
            return customerorders;
        }
        public List<OrderDetail> FindOrderDetailById(int orderID)
        {
            List<OrderDetail> orderDetails = (from od in _context.OrderDetails where od.OrderId == orderID select od).ToList();
            return orderDetails;
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)

        {
            //Order order = _context.Orders.Find(id);
            //return order.OrderDetails.ToList();
            List<Order>ordersWithOrderDetails = _context.Orders.Include(d=>d.OrderDetails).ToList();
            Order order = ordersWithOrderDetails.FirstOrDefault(x=>x.OrderId==id);
            return order.OrderDetails.ToList();

        }

        public List<OrderDetail>FindOrderByOrderId(int id)
        {
            Order order=_context.Orders.Find(id);
            return order.OrderDetails.ToList();
        }
        }
    }



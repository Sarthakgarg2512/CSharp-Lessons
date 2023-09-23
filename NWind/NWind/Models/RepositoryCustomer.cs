using Microsoft.EntityFrameworkCore;

namespace NWind.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthwindContext _context;
        public List<string> GetAllCustomerId()
        {
            List<string> custIds = new List<string>();
            foreach (var customer in _context.Customers)
            {
                custIds.Add(customer.CustomerId);
            }
            return custIds;
        }
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        public Customer FindCustomerById(string id)
        {
            var order = _context.Customers.Find(id);
            return order;
        }
        public List<Order> FindCustomersDetailbyOrders(string id)
        {
            List<Customer> ordersWithOrderDetails = _context.Customers.Include(d => d.Orders).ToList();
            Customer cust = ordersWithOrderDetails.FirstOrDefault(x => x.CustomerId == id);
            return cust.Orders.ToList();
        }
    }
}


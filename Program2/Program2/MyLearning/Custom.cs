using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.MyLearning
{

        public class Customer
        {
            // Properties
            public int CusID { get; set; }
            public string Contact { get; set; }
            public string Address { get; set; }

            // Lists for templates
            public List<Order> Orders { get; set; }
            public List<Bill> Bills { get; set; }
            public List<Complaint> Complaints { get; set; }
            public List<Branch> Branches { get; set; }
            public List<Product> Products { get; set; }

            // Constructor
            public Customer()
            {
                // Initialize lists
                Orders = new List<Order>();
                Bills = new List<Bill>();
                Complaints = new List<Complaint>();
                Branches = new List<Branch>();
                Products = new List<Product>();
            }
        }

        public class Order
        {
            // Order properties
            public int OrderID { get; set; }
            public string OrderDetails { get; set; }
        }

        public class Bill
        {
            // Bill properties
            public int BillID { get; set; }
            public decimal Amount { get; set; }
        }

        public class Complaint
        {
            // Complaint properties
            public int ComplaintID { get; set; }
            public string Description { get; set; }
        }

        public class Branch
        {
            // Branch properties
            public int BranchID { get; set; }
            public string BranchName { get; set; }
        }

        public class Product
        {
            // Product properties
            public int ProductID { get; set; }
            public string ProductName { get; set; }
        }
    }


using Microsoft.AspNetCore.Mvc;
using NWind.Models;

namespace NWind.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositoryCustomer;
        public CustomerController(RepositoryCustomer cust)
        {
            _repositoryCustomer = cust;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            List<string> custIds = _repositoryCustomer.GetAllCustomerId();
            CustomerIdsViewModel idsViewModel = new CustomerIdsViewModel(custIds);
            return View(idsViewModel);
        }
        // GET: CustomerController/Details/5
        public ActionResult Details(string id)
        {
            Customer customer = _repositoryCustomer.FindCustomerById(id); //need to have all the details in the db 
            List<Order> detail = _repositoryCustomer.FindCustomersDetailbyOrders(id);
            ViewData["Order"] = detail;
            return View(customer);
        }
    }
}



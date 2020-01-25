using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Videe.Models;

namespace Videe.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // GET: Customers/Details/Id
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Chris Pratt" }
            };
        }
    }
}
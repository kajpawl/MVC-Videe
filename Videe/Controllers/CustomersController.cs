using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Videe.Models;
using Videe.ViewModels;

namespace Videe.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Chris Pratt" }
            };

            var viewModel = new CustomersListViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        // GET: Customers/Details/Id
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Doe" },
                new Customer { Id = 2, Name = "Chris Pratt" }
            };

            var viewModel = customers.Find(x => x.Id == id);

            return View(viewModel);
        }
    }
}
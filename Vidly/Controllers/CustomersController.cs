using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Name="John Smith" },
                new Customer {Name="Mary Williams" }
            };

            var viewModel = new CustomerViewModel
            {
                Customers = customers
            };
            
            return View(viewModel);
        
        }

        public ActionResult Details(int id)
        {
            var customer = new Customer();

            if (id == 1)
                customer.Name = "John Smith";
            else if (id == 2)
                customer.Name = "Mary Williams";
            else
                return  HttpNotFound();

            return View(customer);

        }
    }
}
using FoodPreference.Models;
using FoodPreference.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodPreference.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff

        private ApplicationDbContext  _context;
        public StaffController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult LoadCustomers()
        {

            return View();
        }


        public ActionResult Edit(int id)
        {

            var customer = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            var viewModel = new StaffViewModel(customer);
            return View("EditCustomer", viewModel);
        }

        public ActionResult AddCustomer()
        {
            return View("EditCustomer");
        }

        [HttpPost]
        public ActionResult SaveCustomer(Customer customer)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new StaffViewModel(customer);


                return View("EditCustomer", viewModel);
            }

            if (customer.Id == 0)
            {
                _context.Customer.Add(customer);
            }

            else
            {
                var customersInDb = _context.Customer.SingleOrDefault(c => c.Id == customer.Id);
                customersInDb.Name = customer.Name;
                customersInDb.Ic = customer.Ic;
                customersInDb.Contact = customer.Contact;
            }
            _context.SaveChanges();
            return RedirectToAction("LoadCustomers","Staff");
        }
    }
}
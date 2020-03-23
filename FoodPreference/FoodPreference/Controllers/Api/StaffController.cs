using System;
using System.Collections.Generic;
using System.Linq;

using System.Web.Http;

using FoodPreference.Models;

namespace FoodPreference.Controllers.Api
{

    public class StaffController : ApiController
    {

        private ApplicationDbContext _context;

        public StaffController()
        {
            _context = new ApplicationDbContext();
        }


        public IHttpActionResult GetCustomer()
        {
            var customerInDb = _context.Customer.ToList();
            return Ok(customerInDb);
        }


        [HttpDelete]

        public IHttpActionResult DeleteCustomer(int id)
        {

            var customerInDb = _context.Customer.SingleOrDefault(c => c.Id == id);
            if (customerInDb == null)
                return NotFound();

            _context.Customer.Remove(customerInDb);
            _context.SaveChanges();
            return Ok();

        }
    }
}

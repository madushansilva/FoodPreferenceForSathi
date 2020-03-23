using FoodPreference.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPreference.ViewModel
{
    public class StaffViewModel
    {
         //public Customer Customer { get; set; }
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Ic { get; set; }
        [Required]
        public int? Contact { get; set; }

        public StaffViewModel()
        {
            Id = 0;
        }
        public StaffViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Ic = customer.Ic;
            Contact = customer.Contact;
        }
    }
}
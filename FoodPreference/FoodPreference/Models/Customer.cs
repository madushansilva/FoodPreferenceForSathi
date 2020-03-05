using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodPreference.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ic { get; set; }

        public int Contact { get; set; }
    }
}
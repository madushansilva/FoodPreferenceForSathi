using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodPreference.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Ic { get; set; }
        [Required]
        public int Contact { get; set; }
    }
}
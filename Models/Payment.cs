using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Payment
    {

        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Bill")]
        public int Bill { get; set; }


        [Display(Name = "Billing Date ")]
        public string billingDate { get; set; }


        public Room room { get; set; }


    }
}

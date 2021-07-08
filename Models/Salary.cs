using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Salary
    {
        public int id { get; set; }

        [Display(Name = "Name ")]
        public string Name { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Salary")]
        public int payment { get; set; }

        [Display(Name = "Payment Date ")]
        public string pymentDate { get; set; }

        public Staff staff { get; set; }
    }
}

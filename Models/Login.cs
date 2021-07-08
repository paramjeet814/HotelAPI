using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Login
    {
        public int id { get; set; }

        [Display(Name = "Enter User Name ")]
        public string Email { get; set; }

        [Display(Name = "Enter Password  ")]
        public int Password { get; set; }
    }
}

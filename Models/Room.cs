using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Room
    {
        public int id { get; set; }

        [Display(Name = "Room Type ")]
        public string roomType { get; set; }

        [Display(Name = "Description ")]
        public string Description { get; set; }

        [Display(Name = "Fair ")]
        public int Fair { get; set; }


    }
}

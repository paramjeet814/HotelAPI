using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class HotelContext : DbContext
    {
        public HotelContext (DbContextOptions<HotelContext> options)
            : base(options)
        {
        }

        public DbSet<Hotel.Models.Room> Room { get; set; }

        public DbSet<Hotel.Models.Staff> Staff { get; set; }

        public DbSet<Hotel.Models.Booking> Booking { get; set; }

        public DbSet<Hotel.Models.Payment> Payment { get; set; }

        public DbSet<Hotel.Models.Salary> Salary { get; set; }

        public DbSet<Hotel.Models.Login> Login { get; set; }
    }
}

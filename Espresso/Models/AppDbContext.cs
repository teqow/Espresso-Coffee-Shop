using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Espresso.Models
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public DbSet<Coffee> Coffees { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

      
    }
}

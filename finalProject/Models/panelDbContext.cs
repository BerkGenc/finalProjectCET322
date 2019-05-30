using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProject.Models;

namespace finalProject.Models
{
    public class panelDbContext : DbContext
    {
        public panelDbContext(DbContextOptions<panelDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<finalProject.Models.Device> Device { get; set; }
    }
}

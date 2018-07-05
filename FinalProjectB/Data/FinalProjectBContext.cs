using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectB.Models;

namespace FinalProjectB.Models
{
    public class FinalProjectBContext : DbContext
    {
        public FinalProjectBContext (DbContextOptions<FinalProjectBContext> options)
            : base(options)
        {
        }

        public DbSet<FinalProjectB.Models.Account> Account { get; set; }

        public DbSet<FinalProjectB.Models.Lead> Lead { get; set; }

        public DbSet<FinalProjectB.Models.Role> Role { get; set; }
    }
}

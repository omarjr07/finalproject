using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjec_v1.Models;

namespace FinalProject_v1.Models
{
    public class FinalProject_v1Context : DbContext
    {
        public FinalProject_v1Context (DbContextOptions<FinalProject_v1Context> options)
            : base(options)
        {
        }

        public DbSet<FinalProject_v1.Models.Account> Account { get; set; }

        public DbSet<FinalProjec_v1.Models.lead> lead { get; set; }

        public DbSet<FinalProject_v1.Models.Role> roles { get; set; }
    }
}

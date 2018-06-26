using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_v1.Models
{
    public class Accounts
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string role { get; set; }
        public string password { get; set; }
    }

    public class AccountsDBContext : DbContext
    {
        public DbSet<Accounts> Accounts { get; set; }
    }
}

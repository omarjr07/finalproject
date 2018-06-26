using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProjec_v1.Models
{
    public class Leads
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string owner { get; set; }
    }

    public class LeadsDBContext : DbContext
    {
        public DbSet<Leads> Leads { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjec_v1.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_v1.Models
{
    public class Account
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string role { get; set; }
        public string password { get; set; }
    }

}

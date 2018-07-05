using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectB.Models
{
    public class Lead
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string owner { get; set; }
    }
}

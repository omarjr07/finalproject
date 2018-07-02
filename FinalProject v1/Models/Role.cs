using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_v1.Models
{
    public class Role
    {
    public int ID { get; set; }
    public bool administrator { get; set; }
    public bool user { get; set; }
    }

}

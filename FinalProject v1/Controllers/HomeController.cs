using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject_v1.Models;

namespace FinalProject_v1.Controllers
{
    public class HomeController : Controller
    {
        //GET: HOME
        public IActionResult Index()
        {
            return View();
        }
        //GET: Admin Portal
        public IActionResult Admin_Portal()
        {
            ViewData["Message"] = "Here you can manage your users.";

            return View();
        }

        public IActionResult Lead_Management()
        {
            //GET: Lead Management
            ViewData["Message"] = "Here you can manage your lead.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

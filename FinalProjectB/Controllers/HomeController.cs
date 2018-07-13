using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProjectB.Models;
using Microsoft.AspNetCore.Http;

namespace FinalProjectB.Controllers
{
    public class HomeController : Controller
    {
        private FinalProjectBContext _context;

        public HomeController(FinalProjectBContext context)
        {
            _context = context;
        }

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

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Account.Add(account);
                _context.SaveChanges(); //Insert user data to table

                ModelState.Clear(); //Clear registration contents
                ViewBag.Message = account.fName + " " + account.lName + "successfully registered.";
            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Account account)
        {
            var UserAccount = _context.Account.Where(u => u.Username == account.Username && u.Password == account.Password).FirstOrDefault();
            if (UserAccount != null) //Add to session
            {
                HttpContext.Session.SetString("ID", UserAccount.ID.ToString());
                HttpContext.Session.SetString("Username", UserAccount.Username);
                HttpContext.Session.SetString("Role", UserAccount.Role);
                return RedirectToAction("Lead");
            }
            else
            {
                ModelState.AddModelError("", "Username or Password is wrong.");
            }
            return View();
        }

        public ActionResult Lead() //Redirect to lead page
        {
            if (HttpContext.Session.GetString("ID") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("Username");
                return RedirectToAction("Index", "Leads");
            }
            else
            {
                return RedirectToAction("Login"); //Redirects to Login page if not valid
            }

        }

        public ActionResult Logout()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}

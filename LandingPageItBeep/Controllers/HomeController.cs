using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LandingPageItBeep.Models;
using LandingPageItBeep.DAL;
using Microsoft.EntityFrameworkCore;
using LandingPageItBeep.Helpers;

namespace LandingPageItBeep.Controllers
{
    public class HomeController : Controller
    {
        private readonly LandingPageItBeepContext _context;

        public HomeController(LandingPageItBeepContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var result = _context.Lookups.Include(lookup => lookup.LookupCategories).ToList();
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SendMail(Email email)
        {
            return Ok(EmailSender.SendEmail(email));
        }
    }
}

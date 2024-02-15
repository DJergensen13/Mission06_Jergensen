using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Jergensen.Models;
using System.Diagnostics;

namespace Mission06_Jergensen.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext name) // constructor
        {
            _context = name;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Application(Application response)
        {
            _context.Applications.Add(response); // add record to the database
            _context.SaveChanges();

            return View("Confirmation");
        }
    }
}

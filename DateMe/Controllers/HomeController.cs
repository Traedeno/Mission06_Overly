using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationContext _context;

        public HomeController(ApplicationContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FIllOutApplication()
        {
            return View("Application");
        }
        [HttpGet]
        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FIllOutApplication(App response)
        {
            if (response.Lent == null) { response.Lent = ""; }
            if (response.Note == null) { response.Note = ""; }
            if (response.Edit == null) { response.Edit = false; }

            _context.Applications.Add(response); // Add record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}

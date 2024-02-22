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
            return View("Application", new App());
        }
        [HttpGet]
        public IActionResult AboutJoel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FIllOutApplication(App response)
        {
            if (response.LentTo == null) { response.LentTo = ""; }
            if (response.Notes == null) { response.Notes = ""; }
            if (response.Edited == null) { response.Edited = 0; }

            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // Add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                return View("Application", response);
            }
        }

        [HttpGet]
        public IActionResult Waitlist()
        {
            //Linq
            var applications = _context.Movies
                .Where(x => x.Rating != "")
                .OrderBy(x => x.Title).ToList();

            return View("Waitlist", applications);
        }

        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Application", recordToEdit); 
        }
        [HttpPost]
        public IActionResult Edit(App updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Waitlist");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View("Delete", recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(App application)
        {
            _context.Movies.Remove(application);
            _context.SaveChanges();

            return RedirectToAction("Waitlist");
        }
    }
}

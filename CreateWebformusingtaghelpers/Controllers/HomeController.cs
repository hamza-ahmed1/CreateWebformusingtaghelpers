using CreateWebformusingtaghelpers.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CreateWebformusingtaghelpers.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Student s)
        {
            if(ModelState.IsValid)
            {
                ModelState.Clear();
            }
            return View();
            //return "RollNumber :" +s.Rollnum+ "\nName :" +s.Name+"\nEmail :"
            //+s.Email+"\nGender :"+s.Gender+"\nMartial Status :"+s.MartialStautus;
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
    }
}
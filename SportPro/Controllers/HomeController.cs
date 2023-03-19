//Member Gowthaman Kangatharan - 101247677

using Microsoft.AspNetCore.Mvc;
using SportPro.Models;
using System.Diagnostics;

namespace SportPro.Controllers
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

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult About() 
        {
            return View();
        }
        public IActionResult Technicians()
        {
            return View();
        }

        public IActionResult Customer() 
        {
            return View();
        }

        public IActionResult Incident()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult AddProducts() 
        {
            return View();
        }

        public IActionResult AddTechnicians() 
        {
            return View();
        }

        public IActionResult AddCustomers() 
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
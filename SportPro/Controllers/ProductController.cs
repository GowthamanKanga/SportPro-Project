//Member Gowthaman Kangatharan - 101247677

using Microsoft.AspNetCore.Mvc;
using SportPro.Models;
using System.Diagnostics;

namespace SportPro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

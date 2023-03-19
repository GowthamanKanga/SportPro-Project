using Microsoft.AspNetCore.Mvc;

namespace SportPro.Controllers
{
    public class IncidentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

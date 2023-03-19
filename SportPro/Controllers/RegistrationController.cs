using Microsoft.AspNetCore.Mvc;

namespace SportPro.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

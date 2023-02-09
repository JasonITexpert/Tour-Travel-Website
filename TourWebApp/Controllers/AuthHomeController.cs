using Microsoft.AspNetCore.Mvc;

namespace TourWebApp.Controllers
{
    public class AuthHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

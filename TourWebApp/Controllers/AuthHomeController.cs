using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TourWebApp.Controllers
{
    [Authorize]
    public class AuthHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

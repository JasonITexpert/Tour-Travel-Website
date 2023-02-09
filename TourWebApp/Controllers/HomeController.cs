using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TourWebApp.Models;

namespace TourWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IEmailSender emailSender)
        {
            this._emailSender = emailSender;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "jp.east.12@gmail.com";
            var subject = "testing mail";
            var message = "this mail is to test if the email sending method is working";
            await _emailSender.SendEmailAsync(receiver, subject, message);
            return View();
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
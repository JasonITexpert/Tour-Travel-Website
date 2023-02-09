
using Microsoft.AspNetCore.Mvc;
using TourWebApp.Data;

namespace TourWebApp.Controllers
{
    public class Booking : Controller
    {
        private readonly ApplicationDbContext _db;
        public Booking(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //GET
        public IActionResult Add()
        {
            return View();
        }

        //GET
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Booking bookingobj)
        {
            if (ModelState.IsValid)
            {
                _db.Add(bookingobj);
                _db.SaveChanges();
                TempData["booknig successfull"] = "Your booking request was successfull";
                return View();
            }
            return View();
        }
    }
}

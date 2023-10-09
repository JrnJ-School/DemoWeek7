using DemoWeek7.Models;
using DemoWeek7.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWeek7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DomainContext _context;

        public HomeController(ILogger<HomeController> logger, DomainContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Create ViewModel for View
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            BookingViewModel model = new()
            {
                Rooms = _context.Rooms.ToList().Select(r => new RoomViewModel(r)).ToList()
            };

            return View(model);
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
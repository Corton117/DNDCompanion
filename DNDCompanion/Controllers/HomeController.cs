using DNDCompanion.Data;
using DNDCompanion.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DNDCompanion.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult SetSession()
        {
            HttpContext.Session.SetString("SessionKeyName", "SessionValue");
            return View();
        }
        
        public IActionResult GetSession()
        {
            var value = HttpContext.Session.GetString("SessionKeyName");
            return View("ViewName", value);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

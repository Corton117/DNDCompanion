using Microsoft.AspNetCore.Mvc;

namespace DNDCompanion.Controllers
{
    public class CharactersController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }
    }
}

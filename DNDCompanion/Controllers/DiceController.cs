using Microsoft.AspNetCore.Mvc;

namespace DNDCompanion.Controllers
{
    public class DiceController : Controller
    {
        public IActionResult Roll(int sides = 20)
        {
            var random = new Random();
            int result = random.Next(1, sides + 1);
            return Json(new { result });
        }
    }

}

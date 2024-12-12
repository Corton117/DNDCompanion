using Microsoft.AspNetCore.Mvc;

namespace DNDCompanion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiceController : Controller
    {
        [HttpGet("roll/{sides}")]
        public IActionResult Roll(int sides = 20)
        {
            var random = new Random();
            int result = random.Next(1, sides + 1);
            return Json(new { result });
        }
    }

}

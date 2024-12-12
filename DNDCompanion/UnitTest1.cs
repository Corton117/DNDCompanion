using DNDCompanion.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly Mock<ILogger<HomeController>> _mockLogger = new Mock<ILogger<HomeController>>();

        [Fact]
        public void Testindex()
        {
            var controller = new HomeController(_mockLogger.Object);

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestPrivacy()
        {
            var controller = new HomeController(_mockLogger.Object);

            var result = controller.Privacy();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void DiceController_Roll_ReturnsJsonResult()
        {
            var controller = new DiceController();

            var result = controller.Roll();

            Assert.IsType<JsonResult>(result);
        }

        [Fact]
        public void DiceController_Index_ReturnsViewResult()
        {
            var controller = new DiceController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
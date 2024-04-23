using Microsoft.AspNetCore.Mvc;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Greeting = "Hello !";
            ViewData["Product"] = new ProductModel()
            {
                Id = 1,
                Name = "Duy Uy Tín",
                Price = 1000
            };
            return View();
        }
    }
}

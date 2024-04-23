using ASPNETCoreForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreForms.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            var model = new ProductEditModel()
            {
                Name = "Test",
                Rate = 100,
                Rating = 100000,
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message;

            if (ModelState.IsValid)
            {
                message = "Product: " + model.Name +
                    ". Rate: " + model.Rate +
                    ". Rating: " + model.Rating + " created successfully";
            }
            else
            {
                return View(model);
            }
            return Content(message);
        }
    }
}

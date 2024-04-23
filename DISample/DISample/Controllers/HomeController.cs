using DISample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IProductService _productService;
        //public HomeController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        public IActionResult Index([FromServices] IProductService _productService)
        {
            var productService = _productService.GetAll();
            return View(productService);
        }
    }
}

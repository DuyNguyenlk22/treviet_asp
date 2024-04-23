using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MVCCoreAPP.Models;

namespace MVCCoreAPP.Controllers
{
    public class ProductController : Controller
    {
        public List<ProductModel> products = new List<ProductModel>()
        {
            new ProductModel() {Id=1,Name="Product1", Available = true , Price = 10000 , PromotionPrice = 8000},
            new ProductModel() {Id=2,Name="Product2", Available = false , Price = 12000 , PromotionPrice = 3000}
        };
        [Route("Product")]
        public IActionResult Index()
        {
            //return Json(products);
            return View(products);
        }
        //[ActionName("modify")]
        //[Route("Product/modify")]

        //[HttpGet]
        //public string Edit(string id)
        //{
        //    return "Hello from edit method";
        //}

        [HttpPost]
        public IActionResult Edit(ProductModel model)
        {
            return RedirectToAction(actionName: "Index", controllerName: "Product");
        }

        //[HttpGet]
        //public List<ProductModel> GetAll()
        //{
        //    return new List<ProductModel>();
        //}

        //[HttpGet("{id}")]
        //public List<ProductModel> GetById(string id)
        //{
        //    return new List<ProductModel>();
        //}

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            //TODO: create a product in DB
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, [FromBody] ProductModel product)
        {
            if (id == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}

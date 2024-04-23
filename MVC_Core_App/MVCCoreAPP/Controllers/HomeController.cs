using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MVCCoreAPP.Models;
using System.Text;

namespace MVCCoreAPP.Controllers
{

    public class HomeController : Controller
    {
        [Route("Home/{id:int?}")]
        public IActionResult Index(int id)
        {
            var model = new IndexModel
            {
                Message = "Hello from HomeController ,ID = " + id
            };
            return View(model);
        }

        //public ActionResult Index(int id)
        //{
        //    if (id == 0)
        //        return NotFound();
        //    return Content("Hello");
        //}
    }
}

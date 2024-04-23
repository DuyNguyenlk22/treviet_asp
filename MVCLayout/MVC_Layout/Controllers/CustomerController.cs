using Microsoft.AspNetCore.Mvc;
using PassingData.Models;

namespace MVC_Layout.Controllers
{
    public class CustomerController : Controller
    {
        [Route("/customer")]
        public IActionResult Index()
        {
            //ViewBag.Customer = new Customer(); 
            var customer = new Customer();
            return View(customer);
        }
    }
}

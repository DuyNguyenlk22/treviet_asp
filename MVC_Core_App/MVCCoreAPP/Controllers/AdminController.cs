using Microsoft.AspNetCore.Mvc;

namespace MVCCoreAPP.Controllers
{
    public class AdminController : Controller
    {
        [Route("/admin")]
        public string Index()
        {
            return "Hello from AdminController";
        }
    }
}

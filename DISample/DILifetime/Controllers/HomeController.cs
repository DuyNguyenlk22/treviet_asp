using DILifetime.Services;
using Microsoft.AspNetCore.Mvc;

namespace DILifetime.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _transientService1;
        ITransientService _transientService2;

        IScopeService _scopedService1;
        IScopeService _scopedService2;

        ISingletonService _singletonService1;
        ISingletonService _singletonService2;

        public HomeController(ITransientService transientService1,
                          ITransientService transientService2,
                          IScopeService scopedService1,
                          IScopeService scopedService2,
                          ISingletonService singletonService1,
                          ISingletonService singletonService2)
        {

            _transientService1 = transientService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;

        }

        public IActionResult Index()
        {

            ViewBag.message1 = "First Instance " + _transientService1.GetId().ToString();
            ViewBag.message2 = "Second Instance " + _transientService2.GetId().ToString();


            ViewBag.message3 = "First Instance " + _scopedService1.GetId().ToString();
            ViewBag.message4 = "Second Instance " + _scopedService2.GetId().ToString();

            ViewBag.message5 = "First Instance " + _singletonService1.GetId().ToString();
            ViewBag.message6 = "Second Instance " + _singletonService2.GetId().ToString();

            return View();
        }
    }
}

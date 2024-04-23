using Microsoft.AspNetCore.Mvc;

namespace MVCCoreAPP.Controllers
{
    [Route("khach-hang")] // attribute routing 
    public class CustomerController : Controller
    {
        [Route("vip")]
        public string Vip()
        {
            return "Khach hang vip";
        }

        [Route("")]
        [Route("normal/{id?}")]
        public string Normal(int id)
        {
            return "Khach hang thuong voi id :" + id;
        }
    }
}

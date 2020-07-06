using Microsoft.AspNetCore.Mvc;

namespace SaiDhamApplication
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

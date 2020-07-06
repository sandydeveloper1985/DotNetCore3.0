using Microsoft.AspNetCore.Mvc;

namespace SaiDhamApplication
{

    /// <summary>
    /// 
    /// </summary>
    public class ClientController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IActionResult Client()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace eCommerce_MVC_.Controllers
{
    public class ItemController : Controller
    {
        /*        public IActionResult Index()
                {
                    return View();
                }*/

        /// <summary>
        /// This method to call the create item view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateItem()
        {
            return View();
        }
    }
}

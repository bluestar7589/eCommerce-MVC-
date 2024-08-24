using Microsoft.AspNetCore.Mvc;

namespace eCommerce_MVC_.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

    }
}

using eCommerce_MVC_.Data;
using eCommerce_MVC_.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce_MVC_.Controllers
{
    public class MembersController : Controller
    {
        private readonly SecondHandContext _context;

        public MembersController(SecondHandContext context)
        {
            _context = context; 
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterViewModel reg) {
            if (ModelState.IsValid) {
                // Mapping data from RegisterViewModel to Member
                Member member = new()
                {
                    Email = reg.Email,
                    Password = reg.Password
                };

                _context.Members.Add(member); // prepare the data to be inserted
                _context.SaveChanges(); // insert the data to database
                LogUserIn(member.Email); // keep the user logged in
                // return to index in home controller
                return RedirectToAction("Index","Home");
            }
            return View(reg);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login) {
            if (ModelState.IsValid)
            {
                Member? user = _context.Members.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "User or password is not correct!");
                    //ViewData["LoginFailed"] = "User or password is not correct!!!";
                    return View(login);
                }
                LogUserIn(login.Email);
                // return to index in home controller
                return RedirectToAction("Index", "Home");
            }
            return View(login);
        }

        /// <summary>
        /// This method to keep the user logged in
        /// </summary>
        /// <param name="email"></param>
        private void LogUserIn(String email)
        {
            HttpContext.Session.SetString("Email", email);
        }

        /// <summary>
        /// This method is used to logout
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("Email");
            return RedirectToAction("Index", "Home");
        }
    }
}

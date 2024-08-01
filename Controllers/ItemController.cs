using eCommerce_MVC_.Data;
using eCommerce_MVC_.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce_MVC_.Controllers
{
    public class ItemController : Controller
    {
        /// <summary>
        /// The context for the database
        /// </summary>
        private readonly SecondHandContext _context;
        public ItemController(SecondHandContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method to call the create item view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult CreateItem()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(Item item) 
        {
            if (ModelState.IsValid) {
                // Add to DB
                // for reference
                // https://learn.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/async-and-stored-procedures-with-the-entity-framework-in-an-asp-net-mvc-application
                _context.Items.Add(item); // prepare to insert to database but not executed yet
                await _context.SaveChangesAsync(); // execute the insert to database

                // Show success message on page
                ViewData["Message"] = $"{item.Name} was added successfully !!!";
                //TempData["Message"] = $"{item.Name} was added successfully !!!"; using when redirect to another page to show this message
                return View();
            }
            return View(item);
        }
    }
}

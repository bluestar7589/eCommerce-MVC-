﻿using eCommerce_MVC_.Data;
using eCommerce_MVC_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_MVC_.Controllers
{
    public class ItemsController : Controller
    {
        /// <summary>
        /// The context for the database
        /// </summary>
        private readonly SecondHandContext _context;
        public ItemsController(SecondHandContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            // Number of items per page
            const int NumberOfItemsPerPage = 1;

            // To get the current page
            int currentPage = id.HasValue ? id.Value : 1;

            // get the number of products in the database
            int totalNumberOfProducts = await _context.Items.CountAsync();

            // Round up the page
            double maxNumPages = Math.Ceiling((double)totalNumberOfProducts / NumberOfItemsPerPage);
            
            int lastPage = Convert.ToInt32(maxNumPages);
            
            // Get all games from database
            List <Item> item = await _context.Items
                                                    .Skip(NumberOfItemsPerPage * (currentPage - 1))
                                                    .Take(NumberOfItemsPerPage)
                                                    .ToListAsync();

            ItemsCatalogViewModel itemsCatalogViewModel = new ItemsCatalogViewModel(item, lastPage, currentPage);
            // Show them o nthe page
            return View(itemsCatalogViewModel);
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

using eCommerce_MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce_MVC_.Data
{
    public class SecondHandContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="options"></param>
        public SecondHandContext(DbContextOptions<SecondHandContext> options) : base(options)
        {
        }

        /// <summary>
        /// Create the table items for the database
        /// </summary>
        public DbSet<Item> Items { get; set; }
    }
}

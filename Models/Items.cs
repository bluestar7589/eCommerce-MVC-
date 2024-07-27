using System.ComponentModel.DataAnnotations;

namespace eCommerce_MVC_.Models
{
    /// <summary>
    /// Represents single item for available for purchase
    /// </summary>
    public class Items
    {
        /// <summary>
        /// Unique identifier for the item
        /// </summary>
        [Key]
        public int ItemId { get; set; }

        /// <summary>
        /// The name for the item
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Description for the item
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// The price for the item
        /// </summary>
        [Range(0,double.MaxValue)]
        public double Price { get; set; }
    }
}

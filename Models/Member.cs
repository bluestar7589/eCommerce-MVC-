using System.ComponentModel.DataAnnotations;

namespace eCommerce_MVC_.Models
{
    public class Member
    {
        /// <summary>
        /// This is represent ID for member
        /// </summary>
        [Key]
        public int MemberId { get; set; }

        /// <summary>
        /// This is represent Email for member
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// This is represent Password for member
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// This is represent UserName for member
        /// </summary>
        public string UserName { get; set; }


        /// <summary>
        /// This is represent PhoneNumber for member
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}

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
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        /// <summary>
        /// This is represent Password for member
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        /// <summary>
        /// This is represent UserName for member
        /// </summary>
        public string? UserName { get; set; }


        /// <summary>
        /// This is represent PhoneNumber for member
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
    }

    public class RegisterViewModel {
        /// <summary>
        /// This is represent Email for member
        /// </summary>
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }

        /// <summary>
        /// This is represent ConfirmEmail for member
        /// </summary>
        [Required]
        [Compare(nameof(Email))]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        /// <summary>
        /// This is represent Password for member
        /// </summary>
        [Required]
        [StringLength(75,MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        /// <summary>
        /// This is represent ConfirmPassword for member
        /// </summary>
        [Required]
        [Compare(nameof(Password))]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string  ConfirmPassword { get; set; }

    }
}

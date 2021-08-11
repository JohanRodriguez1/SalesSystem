using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystem.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "The first name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The last name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The ID is required.")]
        public string ID { get; set; }

        [Required(ErrorMessage = "The phone number is required.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{7})$", ErrorMessage = "The entered phone format is invalid.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The email is required.")]
        [EmailAddress(ErrorMessage = "The entered email format is invalid.")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "The password is required.")]
        [StringLength(10, ErrorMessage = "The number of characters in {0} must be at least {2}", MinimumLength = 5)]
        public string Password { get; set; }

        [Required]
        public string Role { get; set; }
    }
}

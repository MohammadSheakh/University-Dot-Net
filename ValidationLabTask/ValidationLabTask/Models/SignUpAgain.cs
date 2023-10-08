using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationLabTask.Models
{
    public class SignUpAgain
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Name must be between 4 and 50 characters.")]
        [RegularExpression(@"^[a-zA-Z. -]*$", ErrorMessage = "Name can only contain letters, spaces, dots, and dashes.")]
        public string Name { get; set; }


        [Required(ErrorMessage = "User Id is required.")]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "User Id must be between 4 and 12 characters.")]
        [RegularExpression(@"^[a-zA-Z0-9_-]*$", ErrorMessage = "User Id can only contain letters, numbers, dashes, and underscores.")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "ID is required.")]
        [RegularExpression(@"^\d{2}-\d{5}-\d$", ErrorMessage = "ID must follow the format 'xx-xxxxx-x'")]
        public string Id { get; set; }


        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^\d{2}-\d{5}-\d@student.aiub.edu$", ErrorMessage = "Email must follow the format 'xx-xxxxx-x@student.aiub.edu'.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        [RegularExpression(@"^(?=[A-Z]{1}[a-z]{2}[a-z,A-Z]{1}[0-9,!@#$%^&*()-_=+?]{3,})[A-Za-z0-9,!@#$%^&*()-_=+?]{8,}$", ErrorMessage = "Password must have minimum 8 character, first 4 letter must be alphabets at least one upper and 2 lower next 4 must be combination of special character and numbers ")]
        //Password must have minimum 8 character, first 4 letter must be alphabets at least one upper and 2 lower
        //next 4 must be combination of special character and numbers

        public string Password { get; set; }

        [Required(ErrorMessage = "Date of Birth is required.")] // basic one 
        // If set to true, the formatting will be applied in edit mode as well
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        // Custom Validation .. 
        [DateOfBirthAttribute(18, ErrorMessage = "You must be at least 18 years old.")]
        public DateTime Dob { get; set; } //
    }
}
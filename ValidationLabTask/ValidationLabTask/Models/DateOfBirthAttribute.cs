using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationLabTask.Models
{
    public class DateOfBirthAttribute : ValidationAttribute
    {
        // Create a custom validation attribute class that inherits from 
        //ValidationAttribute.In this class, we will implement the validation 
        //logic to check if the user is at least 18 years old.

        private readonly int _minimumAge; // read korte parbo only 
        public DateOfBirthAttribute(int minimumAge)
        {
            _minimumAge = minimumAge;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime dateOfBirth)
            {
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;

                if (dateOfBirth > today.AddYears(-age))
                {
                    age--;
                }

                if (age < _minimumAge)
                {
                    return new ValidationResult($"You must be at least {_minimumAge} years old.");
                }
            }

            return ValidationResult.Success;
            //return base.IsValid(value, validationContext);
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movietoon.Models
{
    public class AdultAgeConfirmationValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            var age = DateTime.Today.Year - customer.YearOfBirth;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("You have to be 18 years old or older to get a membership :(");
        }
    }
}
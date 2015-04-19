using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HelloMVC.Models
{
    class PhoneValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ContactData)validationContext.ObjectInstance;

            if (value == null && model.PhoneNumber == null)
            {
                return new ValidationResult("Please enter either a phone number or email.");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}

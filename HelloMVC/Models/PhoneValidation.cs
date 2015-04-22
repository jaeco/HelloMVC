using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HelloMVC.Models
{
    public class PhoneValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ContactData)validationContext.ObjectInstance;

            if (value == null && model.Email == null)
            {
                return new ValidationResult("Please enter a phone number <OR>");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}

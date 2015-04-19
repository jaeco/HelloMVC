using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HelloMVC.Models
{
    public class EmailValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var model = (ContactData)validationContext.ObjectInstance;

            if(value == null && model.PhoneNumber == null)
            {
                return new ValidationResult("");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}

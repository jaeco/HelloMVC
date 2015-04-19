using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloMVC.Models
{
    public class ContactData
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "Please enter your phone number")]
        [PhoneValidation]
        public string PhoneNumber { get; set; }

        //[Required(ErrorMessage = "Please enter your email address")]
        [EmailValidation]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your age name")]
        [Range(6,9000, ErrorMessage = "Please enter a valid age. (Greater than 5)")]
        public short Age { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SubmissionConfirmation(ContactData contactData)
        {
            if (ModelState.IsValid)
            {
                return View("SubmissionConfirmation", contactData);
            }
            else
            {
/**                if(contactData.PhoneNumber == null || contactData.Email == null)
                {
                ModelState.AddModelError("Phone", "Please enter your phone number or email");
                ModelState.AddModelError("Email", "");
                }
**/
                //validation error
                return View("Index", contactData);
            }
        }
    }
}
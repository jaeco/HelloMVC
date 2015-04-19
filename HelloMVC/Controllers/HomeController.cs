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
                //validation error
                return View("Index", contactData);
            }
        }
    }
}
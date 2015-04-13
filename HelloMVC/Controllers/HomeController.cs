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
        
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult Confirmation()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SubmissionConfirmation(ContactData contactData)
        {
            return View("Test", contactData);
        }
    }
}
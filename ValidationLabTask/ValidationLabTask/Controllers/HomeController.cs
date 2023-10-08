using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationLabTask.Models;

namespace ValidationLabTask.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult SignUpAgain()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SignUpAgain(SignUpAgain signUpAgain)
        {
            if (ModelState.IsValid)
            {
                string id = signUpAgain.Id;
                string email = signUpAgain.Email;
                string idPartFromEmail = "";

                string[] emailParts = email.Split('@');

                if (emailParts.Length > 0)
                {
                    idPartFromEmail = emailParts[0];
                }

                if (id == idPartFromEmail)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    TempData["idAndEmailIsNotSame"] = "Id And Email is not for same person !";
                    return View(signUpAgain);
                }


            }
            return View(signUpAgain);
        }

        [HttpGet]
        public ActionResult Login()
        {
            

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SignUpAgain()
        {
            return View();
        }
    }
}
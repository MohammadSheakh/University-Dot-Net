using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace PortfolioDotNet.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            ViewData["Name"] = "Mohammad Bin Ab. Jalil Sheakh";
            ViewData["Id"] = "20-42132-1";
            ViewData["Email"] = "mohammad.sheakh1@gmail.com";
            ViewData["PhoneNumber"] = 015184198011;
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.hscInstitute = "Dhaka City College";
            ViewBag.hscYear = 2019;
            ViewBag.hscGroup = "Science";
            ViewBag.hscResult = 4.89 ;

            ViewBag.sscInstitute = "Khilgoan Govt. High School";
            ViewBag.sscYear = 2017;
            ViewBag.sscGroup = "Science";
            ViewBag.sscResult = 5.00;
            return View();
        }

        public ActionResult Projects()
        {
            // [row, col]
            string[,] projects = new string[4, 3]{
                                {"OOP1", "Object Oriented Programming", "Basic Course"},
                                {"OOP2", "Object Oriented Programming", "Advance Course"},
                                {"OOP3", "Object Oriented Programming", "Ultra Advance Course"},
                                {"OOP4", "Object Oriented Programming", "Pro Course"}
                            };
            ViewBag.projectsArray = projects;
            return View();
        }

        public ActionResult PersonalInfo()
        {
            return View();
        }

        public ActionResult Reference()
        {
            string[] tanvirSirDetails = { "TANVIR AHMED", "Lecturer , Computer Science", "tanvir.ahmed@aiub.edu" };
            string[] kawsurSirDetails = { "MIR MD KAWSUR", "Lecturer , Computer Science", "kawsur@aiub.edu" };

            ViewBag.kawsurSirDetails = kawsurSirDetails;
            ViewBag.tanvirSirDetails = tanvirSirDetails;


            return View();
        }
    }
}
using u20582006_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20582006_HW04.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Home(string Msg)
        {
            Msg = "Payment succesfully made. Thank you for your donation";
            ViewBag.Message = Msg;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Newsletter()
        {
            return View();
        }

        
    }
}
using u20582006_HW04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

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
            Msg = "Placeholder";
            ViewBag.Message = Msg;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Newsletter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Newsletter(string Msg)
        {
            GetContData();
            Msg = "Placeholder";
            ViewBag.Message = Msg;
            return View();
       
        }

        //Link organisations to Contacts
        private List<Links> GetContData()
        {
            List<Links> Contacts = new List<Links>();
            Links L1 = new Links("June", "Laphela", "Africa", "hubba.org");
            Links L2 = new Links("Ju", "Lin", "Asia", "chingchong.org");
            Links L3 = new Links("Julie", "Luffy", "Australia", "boomrang.org");
            Links L4 = new Links("Juliana", "Linette", "Europe", "baguette.org");
            Links L5 = new Links("Jean", "Lead", "North America", "Burgers.org");
            Links L6 = new Links("Junai", "Linelli", "South America", "Soccer.org");

            Contacts.Add(L1);
            Contacts.Add(L2);
            Contacts.Add(L3);
            Contacts.Add(L4);
            Contacts.Add(L5);
            Contacts.Add(L6);
            return Contacts;
        }
    }
}
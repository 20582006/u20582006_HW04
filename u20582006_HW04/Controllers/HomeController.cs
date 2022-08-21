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
            return View();
       
        }

        //Link organisations to Contacts
        private List<Links> GetContData()
        {
            List<Links> Contacts = new List<Links>();
            Links L1 = new Links("John", "Dallman", "Africa", "info.southafrica@emiworld.org");
            Links L2 = new Links("Paul", "Davis", "Asia", "info@abwe.org");
            Links L3 = new Links("Scott", "Rayberg", "Australia", "info@ewb.org.au");
            Links L4 = new Links("Phil", "Garner", "Europe", "secretariat.general@feani.org");
            Links L5 = new Links("David", "Steinman", "North America", "info@nspe.org");
            Links L6 = new Links("Stephen", "Knight", "South America", "info@volunteerlatinamerica.com");

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
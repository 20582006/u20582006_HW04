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
            Msg = "Placeholder";
            ViewBag.Message = Msg;
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        //
        [HttpGet]
        public ActionResult Newsletter()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Newsletter(string Msg)
        {
            FindCont();

            {
                Msg = "Placeholder";
                ViewBag.Message = Msg;
                return View();
            }
        }

        //Link organisations to Contactss
        private List<Links> GetContData()
        {
            List<Links> Contacts = new List<Links>();
            Links c1 = new Links("Ju", "Lin", "Asia", "chingchong.org");
            Links c2 = new Links("June", "Laphela", "Africa", "hubba.org");
            Links c3 = new Links("Juliana", "Linette", "Europe", "baguette.org");
            Links c4 = new Links("Julie", "Luffy", "Australia", "boomrang.org");
            Links c5 = new Links("Jean", "Lead", "North America", "Burgers.org");
            Links c6 = new Links("Junai", "Linelli", "South America", "Soccer.org");

            Contacts.Add(c1);
            Contacts.Add(c2);
            Contacts.Add(c3);
            Contacts.Add(c4);
            Contacts.Add(c5);
            Contacts.Add(c6);
            return Contacts;
        }

        private string FindCont()
        {
            
            if {
                
            } 
            else
            {

            }
            return Continents;
        }

    }
}
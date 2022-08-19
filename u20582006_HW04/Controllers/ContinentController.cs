using u20582006_HW04.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20582006_HW04.Controllers
{
    public class ContinentController : Controller
    {
        [HttpGet]
        public ActionResult Newsletter()
        {
            List<Links> Continent = GetContData();
            return View(Continent);
        }

        [HttpPost]
        public ActionResult Newsletter(string InfoAboutBusiness)
        {
            InfoAboutBusiness = BusinessClosest();
            return View(InfoAboutBusiness);
        }

        //Link organisations to continents
        private List<Links> GetContData()
        {
            List<Links> Continent = new List<Links>();
            Links c1 = new Links("Ju", "Lin", "Asia", "chingchong.org");
            Links c2 = new Links("June", "Laphela", "Africa", "hubba.org");
            Links c3 = new Links("Juliana", "Linette", "Europe", "baguette.org");
            Links c4 = new Links("Julie", "Luffy", "Australia", "boomrang.org");
            Links c5 = new Links("Jean", "Lead", "North America", "Burgers.org");
            Links c6 = new Links("Junai", "Linelli", "South America", "Soccer.org");

            Continent.Add(c1);
            Continent.Add(c2);
            Continent.Add(c3);
            Continent.Add(c4);
            Continent.Add(c5);
            Continent.Add(c6);
            return Continent;
        }

        private List<Links> BusinessClosest(string BusinessOnCont)
        {
            return "Words";
            //List<Links> ListBusiness = new List<Links>();
       //     switch
          //  BusinessOnCont = "Words";
         //   return BusinessOnCont;
        }
    }
}
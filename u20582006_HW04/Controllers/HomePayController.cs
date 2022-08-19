 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20582006_HW04.Controllers
{
    public class HomePayController : Controller
    {
        // GET: HomePay
        public ActionResult Index()
        {
            List<Home> dogs = GetTestData();
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics_assignment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult FeverCheck()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CompareTemp(double? newNumber, string Temperature)
        {

            if (newNumber == null)
            {
                ViewBag.Message = "Insert a number";
               
            }
            

           if(Temperature.Equals("Celsius"))
            {
                if (newNumber > 37)
                {
                    ViewBag.Message = "You have a fever !";
                }
                else if (newNumber < 35)
                {
                    ViewBag.Message = "You have hypothermia !";
                }
                else
                {
                    ViewBag.Message = "You are just fine";
                }
            }
           else
            {
                if (newNumber > 99.5)
                {
                    ViewBag.Message = "You have a fever !";
                }
                else if (newNumber < 95)
                {
                    ViewBag.Message = "You have hypothermia !";
                }
                else
                {
                    ViewBag.Message = "You are just fine";
                }
            }
                return View("FeverCheck");
        }               
    }
}
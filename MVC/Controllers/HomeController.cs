using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()  //we can also return view result also 
        {

            ViewBag.Countries = new List<string>()
              {

                  "Inida",
                  "USA",
                  "UAE",
                  "PAK"

              };
              
              
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
    }
}
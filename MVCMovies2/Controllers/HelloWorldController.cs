using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMovies2.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HomeView
        public ActionResult Index(string name = "Zaryab", int numOfTime = 4)
        {
            ViewBag.Name = name;
            ViewBag.NumOfTimes = numOfTime;
            /*return RedirectToAction("IndexOne");*/
            return View();
        }

        public string IndexOne()
        {
            return "This is the hello world method from Zaryab";
        }

        public ActionResult WelcomeView(int numOfTime = 0, string name = "")
        {
            ViewBag.NumOfTime = numOfTime;
            ViewBag.Message = "Hello, " + name + ".";
            return View();
        }
        
       /* public Action Button()
        {
            return "<a href="Welcome()"<p>hello</p>";
        }*/
    }
}
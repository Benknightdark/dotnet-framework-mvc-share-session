using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Session.Add("aa", "哏");
            Session["aa"] = Session["aa"] == null ? "null" : Session["aa"].ToString();
            ViewBag.aa = Session["aa"];
            return View();
        }

        public ActionResult About()
        {

          
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
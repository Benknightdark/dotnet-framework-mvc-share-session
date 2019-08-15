using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public HttpContextBase Context { get; set; }
        public HomeController(HttpContextBase context)
        {
            this.Context = context;
        }
        public HomeController()
        {
            //Empty
        }
        public ActionResult Index()
        {
            //Session.RemoveAll();
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "Ben", DateTime.Now, DateTime.Now.AddMinutes(30), false, "", FormsAuthentication.FormsCookiePath);
            string encTicket = FormsAuthentication.Encrypt(ticket);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
        //    Session.Add("CurrentUser", "yo");
            ViewBag.aa = Session["CurrentUser"];

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
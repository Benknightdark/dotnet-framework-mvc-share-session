using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
   public HttpContextBase Context { get; set; }
        public HomeController()
        {
            //Empty
        }
        public HomeController(HttpContextBase context)
        {
            this.Context = context;
        }

        public ActionResult Index()
        {
         //   Session.RemoveAll(); //登入時清空所有 Session 資料
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, "Ben", DateTime.Now, DateTime.Now.AddMinutes(30), false, "", FormsAuthentication.FormsCookiePath);
            string encTicket = FormsAuthentication.Encrypt(ticket);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));
            Session.Add("CurrentUser", "I com from webapp 1");
            ViewBag.aa = Session["CurrentUser"];
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
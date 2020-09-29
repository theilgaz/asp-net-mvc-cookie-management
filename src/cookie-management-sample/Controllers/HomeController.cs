using cookie_management_sample.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cookie_management_sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddCookie()
        {
            CookieHelper.CreateCookie(".NET Version", "4.7");
            CookieHelper.CreateCookie("Year", "2020");
            CookieHelper.CreateCookie("Github Profile", "theilgazcode");
            return View("Index");
        }

        public ActionResult ReadCookie()
        {
            var username = CookieHelper.ReadCookie("Github Profile");
            ViewBag.CookieText = username;
            return View("Index");
        }

        public ActionResult RemoveCookie()
        {
            CookieHelper.RemoveCookie("Year");
            CookieHelper.RemoveCookie(".NET Version");
            CookieHelper.RemoveCookie("Github Profile");
            return View("Index");
        }

        #region Default View Pages
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
        #endregion
    }
}
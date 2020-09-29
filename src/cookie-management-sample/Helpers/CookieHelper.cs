using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cookie_management_sample.Helpers
{
    public static class CookieHelper
    {
        public static void CreateCookie(string name, string value)
        {
            var cookie = new HttpCookie(name, value);
            HttpContext.Current.Response.AppendCookie(cookie);
        }

        public static string ReadCookie(string cookie)
        {
            var c = HttpContext.Current.Request.Cookies[cookie];
            if (c != null) return c.Value;
            return "";
        }

        public static void RemoveCookie(string cookie)
        {
            HttpContext.Current.Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aspnet_MVC_AuthFilter_POC.Filters;

namespace Aspnet_MVC_AuthFilter_POC.Controllers
{
    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        [CustomAuthorize("User", "SystemAdmin")]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthorize("Admin", "SystemAdmin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [CustomAuthorize("SystemAdmin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UnAuthorized()
        {
            ViewBag.Message = "Un Authorized Page!";

            return View();
        }
    }
}
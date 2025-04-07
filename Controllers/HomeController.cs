using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectViwasupco.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView();
            }

            return View();
        }

        public ActionResult Indexv2()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(); 
            }

            return View();
        }

        public ActionResult Indexv3()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(); 
            }

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectViwasupco.Controllers
{
    public class EmailController : Controller
    {
        // GET: Email
        public ActionResult Inbox()
        {
            return View();
        }
        public ActionResult Compose()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Detail()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
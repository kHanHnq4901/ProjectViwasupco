using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectViwasupco.Controllers
{
    public class MapController : Controller
    {
        // GET: Map
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(); // Trả về Partial View
            }

            return View(); // Trả về toàn bộ View khi không phải AJAX
        }
    }
}
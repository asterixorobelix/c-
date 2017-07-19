using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildingMVCApplications.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search()
        {
            return View("Search");
        }
    }
}
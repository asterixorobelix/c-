using BuildingMVCApplications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildingMVCApplications.Controllers
{
    public class HomeController : Controller
    {
        //Instantiate the db
        OdeToFoodDb db = new OdeToFoodDb();

        public ActionResult Index()
        {
            //Retrieve all restaurants in the database, convert it to a list and place it in the model variable.
            var model = db.Restaurants.ToList();

            return View("Index",model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            model.Name = "Nathan";
            model.Location = "Canal Walk";
            ViewBag.Message = "Hello from Cape Town, South Africa";

            return View("About",model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
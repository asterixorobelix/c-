﻿using BuildingMVCApplications.Models;
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
            return View();
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
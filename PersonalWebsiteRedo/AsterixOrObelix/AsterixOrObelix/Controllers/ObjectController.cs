using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsterixOrObelix.Controllers
{
    public class ObjectController : Controller
    {
        // GET: Object
        public ActionResult Index()
        {
            return View();
        }

        // GET: Object/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Object/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Object/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Object/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Object/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Object/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Object/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

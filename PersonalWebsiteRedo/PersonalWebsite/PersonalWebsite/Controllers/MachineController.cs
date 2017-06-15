using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebsite.Controllers
{
    public class MachineController : Controller
    {
        // GET: Machine
        public ActionResult MachineLanding()
        {
            return View("MachineLanding");
        }

        public ViewResult QualityControlRig()
        {
            return View("QualityControlRig");
        }
    }
}
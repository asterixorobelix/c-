
namespace SerenityOdeToFood.Common.Pages
{
    using Serenity;
    using Serenity.Data;
    using System;
    using System.Web.Mvc;
    using SerenityOdeToFood.Data;
    using System.Linq;

    [RoutePrefix("Dashboard"), Route("{action=index}")]
    public class DashboardController : Controller
    {
        Data.SerenityOdeToFoodDb db = new Data.SerenityOdeToFoodDb();

        [Authorize, HttpGet, Route("~/")]
        public ActionResult Index()
        {
            var model = db.Restaurants.ToList();

            return View(MVC.Views.Common.Dashboard.DashboardIndex, model);
        }
    }
}

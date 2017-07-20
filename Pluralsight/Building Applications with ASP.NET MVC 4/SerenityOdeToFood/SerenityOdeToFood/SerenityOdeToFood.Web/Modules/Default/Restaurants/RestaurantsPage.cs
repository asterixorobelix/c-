

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Restaurants", typeof(SerenityOdeToFood.Default.Pages.RestaurantsController))]

namespace SerenityOdeToFood.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Restaurants"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.RestaurantsRow))]
    public class RestaurantsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Restaurants/RestaurantsIndex.cshtml");
        }
    }
}
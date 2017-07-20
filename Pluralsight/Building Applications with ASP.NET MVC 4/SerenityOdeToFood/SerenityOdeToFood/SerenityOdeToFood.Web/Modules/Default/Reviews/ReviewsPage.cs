

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Reviews", typeof(SerenityOdeToFood.Default.Pages.ReviewsController))]

namespace SerenityOdeToFood.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Reviews"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ReviewsRow))]
    public class ReviewsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Reviews/ReviewsIndex.cshtml");
        }
    }
}
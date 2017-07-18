

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "Default/Applications", typeof(SerenityPractice1.Default.Pages.ApplicationsController))]

namespace SerenityPractice1.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Applications"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.ApplicationsRow))]
    public class ApplicationsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Applications/ApplicationsIndex.cshtml");
        }
    }
}
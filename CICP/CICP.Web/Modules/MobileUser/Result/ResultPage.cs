

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MobileUser/Result", typeof(CICP.MobileUser.Pages.ResultController))]

namespace CICP.MobileUser.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MobileUser/Result"), Route("{action=index}")]
    public class ResultController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/MobileUser/Result/ResultIndex.cshtml");
        }
    }
}


[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MobileUser/MobileAccount", typeof(CICP.MobileUser.Pages.MobileAccountController))]

namespace CICP.MobileUser.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MobileUser/MobileAccount"), Route("{action=index}")]
    public class MobileAccountController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/MobileUser/MobileAccount/MobileAccountIndex.cshtml");
        }
    }
}
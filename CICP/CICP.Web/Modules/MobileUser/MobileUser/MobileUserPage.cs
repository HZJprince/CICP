

[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MobileUser/MobileUser", typeof(CICP.MobileUser.Pages.MobileUserController))]

namespace CICP.MobileUser.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MobileUser/MobileUser"), Route("{action=index}")]
    public class MobileUserController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/MobileUser/MobileUser/MobileUserIndex.cshtml");
        }
    }
}


[assembly:Serenity.Navigation.NavigationLink(int.MaxValue, "MobileUser/RongTuo", typeof(CICP.MobileUser.Pages.RongTuoController))]

namespace CICP.MobileUser.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MobileUser/RongTuo"), Route("{action=index}")]
    public class RongTuoController : Controller
    {
        [PageAuthorize("Administration")]
        public ActionResult Index()
        {
            return View("~/Modules/MobileUser/RongTuo/RongTuoIndex.cshtml");
        }
    }
}
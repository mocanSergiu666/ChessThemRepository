using System.Web.Mvc;

namespace ChessThem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

		[ChildActionOnly]
		public PartialViewResult GetConnectionFailPopup()
		{
			return PartialView("_GetConnectionFailPopupPartial");
		}

		public ActionResult Connect()
		{
			return RedirectToAction("GetBoard", "Game");
		}
	}
}
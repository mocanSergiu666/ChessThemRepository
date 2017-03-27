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
		public PartialViewResult ConnectionFailPopup()
		{
			return PartialView("_ConnectionFailPopupPartial");
		}
	}
}
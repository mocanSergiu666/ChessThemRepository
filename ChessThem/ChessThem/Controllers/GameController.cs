using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChessThem.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

		public PartialViewResult GetBoard()
		{
			return PartialView("_GetBoardPartial");
		}
	}
}
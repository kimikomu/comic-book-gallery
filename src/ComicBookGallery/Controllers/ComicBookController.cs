using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	// create a controller from the controller parent
	public class ComicBookController : Controller
	{
		// call an action method that returns an ActionResult type
		public ActionResult Detail()
		{
			// Displays the file named after this method (Detail) from the folder named after the controller calling the method (ComicBook) in the Views folder.
			return View();
		}
	}
}
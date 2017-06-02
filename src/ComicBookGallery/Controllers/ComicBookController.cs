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
			ViewBag.SeriesTitle = "The Amazing Spider-Man";
			ViewBag.IssueNumber = 700;
			ViewBag.Description = "<p>Final issue! Witness the last hours of Doc Octopus' life and his one last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
			ViewBag.Artists = new string[]
			{
				"Script: Dan Slott",
				"Pencils: Humberto Ramos",
				"Inks: Victor Olazaba",
				"Colors: Edgar Delgado",
				"Letters: Chris Eliopoulos"
			};

			// Displays the file named after this method (Detail) from the folder named after the controller calling the method (ComicBook) in the Views folder.
			return View();
		}
	}
}
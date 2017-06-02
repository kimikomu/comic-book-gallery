using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
	// create a controller from the controller parent
	public class ComicBookController : Controller
	{
		// call an action method that returns an ActionResult type
		public ActionResult Detail()
		{
			var comicBook = new ComicBook()
			{
				SeriesTitle = "The Amazing Spider-Man",
				IssueNumber = 700,
				DescriptionHtml = "<p>Final issue! Witness the last hours of Doc Octopus' life and his one last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
				Artists = new Artists[]
				{
					new Artists() { Name = "Dan Slott", Role = "Script" },
					new Artists() { Name = "Humberto Ramos", Role = "Pencils" },
					new Artists() { Name = "Victor Olazaba", Role = "Inks" },
					new Artists() { Name = "Edgar Delgado", Role = "Colors" },
					new Artists() { Name = "Chris Eliopoulos", Role = "Letters" }
				}
		};

			// Displays the file named after this method (Detail) from the folder named after the controller calling the method (ComicBook) in the Views folder.
			return View(comicBook);
		}
	}
}
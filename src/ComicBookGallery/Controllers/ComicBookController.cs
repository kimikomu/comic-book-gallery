using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookGallery.Data;
using ComicBookGallery.Models;

namespace ComicBookGallery.Controllers
{
	// create a controller from the controller parent
	public class ComicBookController : Controller
	{
		// field
		private ComicBookRepository _comicBookRepository = null;

		// constructor
		public ComicBookController()
		{
			_comicBookRepository = new ComicBookRepository();
		}
		
		// call an action method that returns an ActionResult type
		public ActionResult Detail(int? id)	// ? makes the parameter nullable so MVC can pass null if an id is not part of the request. ints default to 0, not null.
		{
			if (id == null)
			{
				return HttpNotFound();	// HttpNotFound is a preexisting object that returns a 404
			}

			var comicBook = _comicBookRepository.GetComicBook((int)id);	// cast back to int bc int? is not the same as int

			// Displays the file named after this method (Detail) from the folder named after the controller calling the method (ComicBook) in the Views folder.
			return View(comicBook);
		}
	}
}
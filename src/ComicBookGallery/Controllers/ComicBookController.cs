using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
	public class ComicBookController : Controller
	{
		public ActionResult Detail()
		{
			// if today is Monday
			if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
			{
				return Redirect("/");
			}
			return Content("Hello from the comic books controller!");
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int Id { get; set; }	// uniquely identifies a comic book
		public string SeriesTitle { get; set; }	// represents the title of the series this comic book is part of
		public int IssueNumber { get; set; }	// comic book's issue number
		public string DescriptionHtml { get; set; }	// adding Html to the name makes it clear that it will have html content
		public Artists[] Artists { get; set; }	// array of objects of type Artists
		public bool Favorite { get; set; }	// indicates whether or not this comic is a favorite of ours or not
	}
}
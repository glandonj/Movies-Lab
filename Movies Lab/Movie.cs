using System;
namespace Movies_Lab
{
	public class Movie
	{
		//properties
		public string Title { get; set; }
		public string Category { get; set; }

		//Constructor
		public Movie(string _title, string _category)
		{
			Title = _title;
			Category = _category;
		}
		//methods
		public string GetDetails()
		{
            return String.Format("{0,-25} {1, -25}", $"{Title}",$"{Category}");
		}
	}
}


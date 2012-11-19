using System;

namespace prep.collections
{
  public class Movie : IEquatable<Movie>
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }

	public override bool Equals(object obj)
	{
		if (obj is Movie)
		{
			Movie temp = obj as Movie;
			if (title != temp.title) { return (false); }
			if (production_studio != temp.production_studio) { return (false); }
			if (genre != temp.genre) { return (false); }
			if (rating != temp.rating) { return (false); }
			if (date_published != temp.date_published) { return (false); }

			return (true);
		}
		else { return (false); }
	}

	public bool Equals(Movie temp)
	{
		if (title != temp.title) { return (false); }
		if (production_studio != temp.production_studio) { return (false); }
		if (genre != temp.genre) { return (false); }
		if (rating != temp.rating) { return (false); }
		if (date_published != temp.date_published) { return (false); }

		return (true);
	}
  }
}
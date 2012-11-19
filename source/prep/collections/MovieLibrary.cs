using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
		foreach (Movie movie in movies)
		{
			yield return movie;
		}
    }

    public void add(Movie movie)
    {
		if (movies.Contains(movie)) { return; }
		movies.Add(movie);
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
		IList<Movie> listOfMoviesPublishedByPixar = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if (movie.production_studio == ProductionStudio.Pixar)
				listOfMoviesPublishedByPixar.Add(movie);
		}

		return (listOfMoviesPublishedByPixar);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
		IList<Movie> listOfMoviesPublishedByPixarOrDisney = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if ((movie.production_studio == ProductionStudio.Pixar) || (movie.production_studio == ProductionStudio.Disney))
				listOfMoviesPublishedByPixarOrDisney.Add(movie);
		}

		return (listOfMoviesPublishedByPixarOrDisney);
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
		IList<Movie> listOfMoviesNotPublishedByPixar = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if (movie.production_studio != ProductionStudio.Pixar)
				listOfMoviesNotPublishedByPixar.Add(movie);
		}

		return (listOfMoviesNotPublishedByPixar);
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
		IList<Movie> listOfMoviesPublishedAfterYear = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if (movie.date_published.Year > year)
				listOfMoviesPublishedAfterYear.Add(movie);
		}

		return (listOfMoviesPublishedAfterYear);
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
		IList<Movie> listOfMoviesPublishedBetweenYears = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if ((movie.date_published.Year >= startingYear) && (movie.date_published.Year <= endingYear))
				listOfMoviesPublishedBetweenYears.Add(movie);
		}

		return (listOfMoviesPublishedBetweenYears);
    }

    public IEnumerable<Movie> all_kid_movies()
    {
		IList<Movie> listOfKidMovies = new List<Movie>();
		foreach(Movie movie in movies)
		{
			if (movie.genre == Genre.kids)
				listOfKidMovies.Add(movie);
		}

		return (listOfKidMovies);
    }

    public IEnumerable<Movie> all_action_movies()
    {
		IList<Movie> listOfKidMovies = new List<Movie>();
		foreach (Movie movie in movies)
		{
			if (movie.genre == Genre.action)
				listOfKidMovies.Add(movie);
		}

		return (listOfKidMovies);
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      throw new NotImplementedException();
    }
  }
}
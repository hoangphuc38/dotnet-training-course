using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst
{
    public class Client
    {
        /// <summary>
        /// Get list of movies with name and price from database
        /// </summary>
        public void GetMovieList()
        {
            using (var db = new MovieDBEntities())
            {
                IQueryable<Movie> movieList = from m in db.Movies
                                              orderby m.Price descending
                                              select m;

                Console.WriteLine("- All movies: ");
                foreach (var item in movieList)
                {
                    Console.WriteLine(
                        "ID: " + item.ID + 
                        " - Title: " + item.Title + 
                        " - price: " + item.Price);
                }

                Console.WriteLine("\n\nClick Enter to continue\n");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Get a movie's information by its name
        /// </summary>
        /// <param name="movieName">movieName</param>
        public void GetMovieInfo(string movieName)
        {
            using (var db = new MovieDBEntities())
            {
                var movie = (from m in db.Movies
                                          where m.Title == movieName
                                          select m).Single();

                Console.WriteLine("- Movie's information: ");
                Console.WriteLine("ID: " + movie.ID);
                Console.WriteLine("Title: " + movie.Title);
                Console.WriteLine("GenreName: " + movie.Genre.GenreName);
                Console.WriteLine("Rating: " + movie.Rating);
                Console.WriteLine("ReleaseDate: " + movie.ReleaseDate);
                Console.WriteLine("Price: " + movie.Price);

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Show list of genres
        /// </summary>
        public void GetGenreList()
        {
            using (var db = new MovieDBEntities())
            {
                IQueryable<Genre> genreList = from g in db.Genres
                                orderby g.GenreName 
                                select g;

                Console.WriteLine("- All genres: ");
                foreach (var item in genreList)
                {
                    Console.WriteLine("ID: " + item.ID + " - GenreName: " + item.GenreName);
                }

                Console.WriteLine("\n\nClick Enter to continue\n");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Add a new genre in database
        /// </summary>
        /// <param name="genreName">genreName</param>
        public void AddGenre(string genreName)
        {
            Genre genre = new Genre();

            genre.GenreName = genreName;

            using (var db = new MovieDBEntities())
            {
                db.Genres.Add(genre);
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Update the name of genre
        /// </summary>
        /// <param name="genreID">genreNameBefore</param>
        /// <param name="genreName">genreNameAfter</param>
        public void UpdateGenre(string genreID, string genreName)
        {
            int genreIDParse = int.Parse(genreID);
            using (var db = new MovieDBEntities())
            {
                var genre = (from g in db.Genres
                             where g.ID == genreIDParse
                             select g).Single();

                genre.GenreName = genreName;
                db.SaveChanges();
            }
        }

        /// <summary>
        /// Delete a genre
        /// </summary>
        /// <param name="genreID"></param>
        public void DeleteGenre(string genreID)
        {
            int genreIDParse = int.Parse(genreID);
            using (var db = new MovieDBEntities())
            {
                var genre = (from g in db.Genres
                              where (g.ID == genreIDParse)
                              select g).Single();

                db.Genres.Remove(genre);
                db.SaveChanges();
            }
        }
    }
}

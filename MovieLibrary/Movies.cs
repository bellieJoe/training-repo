using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Movies
    {
        private List<Movie> movieList = new List<Movie>();
        

        public void addMovie()
        {
            int id;
            string title, director, dateReleased, genre;

            if (movieList.Count > 0)
            {
                id = movieList[movieList.Count - 1].Id + 1;
            }
            else
            {
                id = 1;
            }

            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Director: ");
            director = Console.ReadLine();
            Console.Write("Date Released: ");
            dateReleased = Console.ReadLine();
            Console.Write("Genre: ");
            genre = Console.ReadLine();

            movieList.Add(new Movie(id, title, director, dateReleased, genre));
            //movieList[movieList.Count] = new Movie(id, title, director, dateReleased, genre);
        }

        public void displayMovies()
        {
            
            if(this.movieList.Count == 0)
            {
                Console.WriteLine("\n\nNo Movies to show");
            }
            else
            {
                foreach(Movie movie in movieList)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Id: " + movie.Id);
                    Console.WriteLine("Title: " + movie.Title);
                    Console.WriteLine("Director: " + movie.Director);
                    Console.WriteLine("Genre: " + movie.Genre);
                    Console.WriteLine("Date Released: " + movie.DateReleased);
                }
            }
        }

    }
}

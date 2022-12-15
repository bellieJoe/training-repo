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
                Console.WriteLine("\nMOVIES");
                foreach (Movie movie in movieList)
                {
                    Console.WriteLine("Id: " + movie.Id);
                    Console.WriteLine("Title: " + movie.Title);
                    Console.WriteLine("Director: " + movie.Director);
                    Console.WriteLine("Genre: " + movie.Genre);
                    Console.WriteLine("Date Released: " + movie.DateReleased);
                    Console.WriteLine("Raitng: " + movie.computeRatingSummary() + "/5");
                    Console.WriteLine("\n");
                }
            }
        }

        public void addRating()
        {
            int id;
            double rate;
            string review, name;

            displayMovies();

            Console.WriteLine("ADD RATING");
            Console.Write("Movie Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Review: ");
            review = Console.ReadLine();
            Console.Write("Rate: ");
            rate = Convert.ToDouble(Console.ReadLine());

            int index = movieList.FindLastIndex(movie => movie.Id == id);
            foreach (Movie movie in movieList)
            {
                if(movie.Id == id)
                {
                    Rating r = new Rating(name, review, rate);
                    movie.addRating(r);
                }
            }
        }

        public void printTop10()
        {
            List<Movie> newList = new List<Movie>();
            int counter = 0;
            if (this.movieList.Count == 0)
            {
                Console.WriteLine("\n\nNo Movies to show");
            }
            else
            {
                foreach(Movie movie in movieList)
                {
                    newList.Add(movie);
                }
                newList.Sort(sortMovieByRating);
                Console.WriteLine("\nMOVIES");
                foreach (Movie movie in newList)
                {
                    if (counter < 11)
                    {
                        Console.WriteLine("Id: " + movie.Id);
                        Console.WriteLine("Title: " + movie.Title);
                        Console.WriteLine("Director: " + movie.Director);
                        Console.WriteLine("Genre: " + movie.Genre);
                        Console.WriteLine("Date Released: " + movie.DateReleased);
                        Console.WriteLine("Raitng: " + movie.computeRatingSummary() + "/5");
                        Console.WriteLine("\n");
                    }
                    counter++;
                }
                
            }
            
        }

        private static int sortMovieByRating(Movie a, Movie b)
        {
            if (a.computeRatingSummary() == b.computeRatingSummary())
            {
                return 0;
            }
            if (a.computeRatingSummary() > b.computeRatingSummary())
            {
                return -1;
            }
            return 1;
        }

        public void viewReviews()
        {
            int id;

            displayMovies();

            Console.Write("Movie Id: ");
            id = Convert.ToInt32(Console.ReadLine());
            foreach(Movie movie in movieList)
            {
                if(movie.Id == id)
                {
                    Console.WriteLine("\n" + movie.Title + " reviews");
                    foreach(Rating rating in movie.Ratings)
                    {
                        Console.WriteLine("Name: " + rating.Name);
                        Console.WriteLine("Rate: " + rating.Rate + "/5");
                        Console.WriteLine("Review: " + rating.Review);
                        Console.WriteLine("\n");
                    }
                }
            }
        }

    }
}

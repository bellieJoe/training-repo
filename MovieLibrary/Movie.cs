using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Movie
    {
        // properties
        private int id;
        private string title;
        private string director;
        private string dateReleased;
        private string genre;
        private List<Rating> ratings =  new List<Rating>();

        // constructors
        public Movie(int id, string title, string director, string dateReleased, string genre)
        {
            this.id = id;
            this.title = title;
            this.director = director;
            this.dateReleased = dateReleased;
            this.genre = genre;
        }

        // getters and setters
        public int Id { get => id; }
        public string DateReleased { get => dateReleased; set => dateReleased = value; }
        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public string Genre { get => genre; set => genre = value; }
        internal List<Rating> Ratings { get => ratings; }

        // methods
        public double computeRatingSummary()
        {
            double total = 0;
            int count = 0;
            foreach (Rating rating in ratings)
            {
                count++;
                total += rating.Rate;
            }
            return count != 0 ? total / count : 0;
        }

        public void addRating(Rating rating)
        {
            ratings.Add(rating);
        }
    }
}

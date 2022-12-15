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
        private Rating[] ratings;

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

        // methods
        public void printTop10()
        {

        }

        public int computeRatingSummary()
        {
            return 0;
        }

        public void addRating()
        {

        }
    }
}

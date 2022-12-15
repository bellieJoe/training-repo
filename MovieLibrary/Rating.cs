using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Rating
    {
        private string name;
        private string review;
        private double rate;

        public Rating(string name, string review, double rate)
        {
            this.name = name;
            this.review = review;
            this.rate = rate;
        }

        public string Name { get => name; set => name = value; }
        public string Review { get => review; set => review = value; }
        public double Rate { get => rate; set => rate = value; }
    }
}

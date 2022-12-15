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
        private int rate;

        public Rating(string name, string review, int rate)
        {
            this.name = name;
            this.review = review;
            this.rate = rate;
        }

        public string Name { get => name; set => name = value; }
        public string Review { get => review; set => review = value; }
        public int Rate { get => rate; set => rate = value; }
    }
}

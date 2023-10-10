using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Getters_and_Setters
{
    class Movie
    {
        public string titte;
        public string director;
        private string rating;

        public Movie(string aTitte, string aDirector, string aRating)
        {
            titte = aTitte;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "16")
                    rating = value;
                else
                    rating = "No Rating";
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic","Jim","PG-13");
            Movie movie2 = new Movie("Unreleased", "Moloko", "PG");

            Console.WriteLine("Movie 1 Rating: " + movie1.Rating);
            Console.WriteLine("Movie 2 Tittle: " + movie2.titte);
            Console.Read();
        }
    }
}

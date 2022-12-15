using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary
{
    class Program
    {
        static Movies m = new Movies();


        public static void displayMenu()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*         WELCOME TO MOVIELIB         *");
            Console.WriteLine("*        Movie Personal Ratings       *");
            Console.WriteLine("***************************************");
            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("ENTER 1: Display all Movies, Ratings and Reviews");
            Console.WriteLine("ENTER 2: Add new Movie");
            Console.WriteLine("ENTER 3: Add new Ratings");
            Console.WriteLine("ENTER 4: Display Top 10 Movies");
            Console.WriteLine("ENTER 0: Exit Application");
            Console.Write("\nINPUT: ");
        }


        public static void processInput(int userInput)
        {
            switch (userInput)
            {
                case 1:
                    m.displayMovies();
                    break;
                case 2:
                    m.addMovie();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }


        public static void startApplication()
        {
            int userInput;
            do
            {
                displayMenu();
                userInput = Convert.ToInt32(Console.ReadLine());
                processInput(userInput);
                Console.Write("\nPRESS ENTER TO CONTINUE");
                Console.ReadLine();
                Console.Clear();
            }
            while (userInput != 0);
        }


        

        static void Main(string[] args)
        {
            startApplication();
            Console.ReadLine();
        }
    }
}

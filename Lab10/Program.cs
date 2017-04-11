using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!");

            List<Movie> movies = new List<Movie>()
            {
                new Movie("Heavy Metal", "Animated"),
                new Movie("The Ring", "Horror"),
                new Movie("Artificial Intelligence", "Sci-Fi"),
                new Movie("Independence Day", "Sci-Fi"),
                new Movie("Titanic", "Drama"),
                new Movie("Star Wars", "Sci-Fi"),
                new Movie("Cabin in the Woods", "Horror"),
                new Movie("Kubo and the Two Strings", "Animated")
            };

            Console.WriteLine("\nThere are " + movies.Count + " movies in this list.");

            bool run = true;
            while (run)
            {
                Console.WriteLine("Categories");
                Console.WriteLine("==========");
                Console.WriteLine("1: Animated");
                Console.WriteLine("2: Drama");
                Console.WriteLine("3: Horror");
                Console.WriteLine("4: Sci-Fi");

                Console.WriteLine("What category are you interested in?");

                string userCategory = GetInput();

                Console.WriteLine("\nCategory: " + userCategory);
                Console.WriteLine("==========================");

                foreach (Movie movie in movies)
                {
                    //Print movie titles that match user's category
                    if (movie.GetCategory().Equals(userCategory))
                    {
                        movie.PrintTitle();
                    }
                }

                Console.WriteLine("\nContinue? (y/n):");
                run = Continue();
            }
        }

        public static string GetInput()
        {
            int input = -1;
            string category = "";
            bool isValidInput = false;
            do
            { 
                try
                {
                    input = int.Parse(Console.ReadLine()); 
                    if(input < 1 || input > 4)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    isValidInput = true;
                }
                catch (System.FormatException)
                {
                    isValidInput = false;
                    Console.WriteLine("Input must be 1-4. Try again:");
                }
                catch (IndexOutOfRangeException)
                {
                    isValidInput = false;
                    Console.WriteLine("Input must be 1-4. Try again:");
                }      
            } while (isValidInput == false);

            switch (input)
            {
                case 1:
                    category = "Animated";
                    break;

                case 2:
                    category = "Drama";
                    break;

                case 3:
                    category = "Horror";
                    break;

                case 4:
                    category = "Sci-Fi";
                    break;

                default:
                    Console.WriteLine("Invalid category");
                    break;
            }

            return category;
        }

        //Continue program?
        public static bool Continue()
        {
            string input = Console.ReadLine().ToLower();
            bool run = false;

            if (input.Equals("n"))
            {
                run = false;
            }
            else if (input.Equals("y"))
            {
                run = true;
            }
            else
            {
                Console.WriteLine("\nInvalid input! Please type y/n:");
                run = Continue();
            }

            return run;
        }
    }
}

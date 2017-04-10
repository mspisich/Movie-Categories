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

            List<Movie> movies = new List<Movie>();

            Movie heavyMetal = new Movie("Heavy Metal", "animated");
            movies.Add(heavyMetal);

            Movie theRing = new Movie("The Ring", "horror");
            movies.Add(theRing);

            Movie artificialIntelligence = new Movie("Artificial Intelligence", "scifi");
            movies.Add(artificialIntelligence);

            Movie independenceDay = new Movie("Independence Day", "scifi");
            movies.Add(independenceDay);

            Movie titanic = new Movie("Titanic", "drama");
            movies.Add(titanic);

            Movie starWars = new Movie("Star Wars", "scifi");
            movies.Add(starWars);

            Movie cabinInTheWoods = new Movie("Cabin in the Woods", "horror");
            movies.Add(cabinInTheWoods);

            Movie kuboAndTheTwoStrings = new Movie("Kubo and the Two Strings", "animated");
            movies.Add(kuboAndTheTwoStrings);

            Console.WriteLine("\nThere are " + movies.Count + " movies in this list.");

            bool run = true;
            while (run)
            {
                Console.WriteLine("Categories");
                Console.WriteLine("==========");
                Console.WriteLine("0: Animated");
                Console.WriteLine("1: Drama");
                Console.WriteLine("2: Horror");
                Console.WriteLine("3: Sci-Fi");

                Console.WriteLine("What category are you interested in?");

                string userCategory = GetInput();

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
                    if(input < 0 || input > 3)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    isValidInput = true;
                }
                catch (System.FormatException)
                {
                    isValidInput = false;
                    Console.WriteLine("Input must be 0-3. Try again:");
                }
                catch (IndexOutOfRangeException)
                {
                    isValidInput = false;
                    Console.WriteLine("Input must be 0-3. Try again:");
                }      
            } while (isValidInput == false);

            switch (input)
            {
                case 0:
                    category = "animated";
                    break;

                case 1:
                    category = "drama";
                    break;

                case 2:
                    category = "horror";
                    break;

                case 3:
                    category = "scifi";
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

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

            Movie dramaFilm = new Movie("Some Drama Film", "drama");
            movies.Add(dramaFilm);

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
                Console.WriteLine("What category are you interested in? (animated, drama, horror, scifi):");

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
            string input;
            bool isValidInput = false;
            do
            {
                input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "animated":
                        isValidInput = true;
                        break;

                    case "drama":
                        isValidInput = true;
                        break;

                    case "horror":
                        isValidInput = true;
                        break;

                    case "scifi":
                        isValidInput = true;
                        break;

                    default:
                        try
                        {
                            throw new IndexOutOfRangeException();
                        }
                        catch (Exception e)
                        {
                            isValidInput = false;
                            Console.WriteLine("Category must be animated, drama, horror, or scifi! Try again:");
                        }
                        break;
                }

            } while (isValidInput == false);

            return input;
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

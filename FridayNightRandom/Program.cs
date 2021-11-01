using System;

namespace FridayNightRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "salad", "fish" };
            

            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drink = { "coca", "fanta", "juice", "water", "tea" };
            
            Console.WriteLine($"Computer picked: {drink[GenerateRandomIndex(drink)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "Grinch", "MrandMsSmith", "YOU", "PrisonBreak", "Shrek" };
            
            Console.WriteLine($"Computer picked: {movie[GenerateRandomIndex(movie)]}");

       
        }
    }

}

using System;

namespace FunctionsReturnAndArraysFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "salad", "fish" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, foods.Length);

            string randomFood = foods[randomIndex];
            Console.WriteLine($"Computer picked: {randomFood}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drink = { "coca", "fanta", "juice", "water", "tea" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, drink.Length);

            string randomDrink = drink[randomIndex];
            Console.WriteLine($"Computer picked: {randomDrink}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movie = { "Grinch", "MrandMsSmith", "YOU", "PrisonBreak", "Shrek" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, movie.Length);

            string randomMovie = movie[randomIndex];
            Console.WriteLine($"Computer picked: {randomMovie}");
        }
    }
}

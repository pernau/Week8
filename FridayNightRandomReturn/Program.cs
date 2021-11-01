using System;

namespace FridayNightRandomReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomFood, randomDrink, randomMovie;
            string[] foods = { "chicken wings", "pizza", "sushi", "salad", "fish" };
            string[] drink = { "coca", "fanta", "juice", "water", "tea" };
            string[] movie = { "Grinch", "MrandMsSmith", "YOU", "PrisonBreak", "Shrek" };

            randomFood = PickRandomElementFromArray(foods);
            randomDrink = PickRandomElementFromArray(drink);
            randomMovie = PickRandomElementFromArray(movie);

            Console.WriteLine($"Tonight you will have some {randomFood} with {randomDrink} and watch {randomMovie} ");
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        
        
        private static string PickRandomElementFromArray(string[] someArray)
        {
            string randomElement = someArray[GenerateRandomIndex(someArray)];
            return randomElement;

         
        }
}
    }
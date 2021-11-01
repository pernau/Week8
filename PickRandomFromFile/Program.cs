﻿using System;
using System.IO;

namespace PickRandomFromFile
{
    class Program
    {
        static void Main(string[] args)

        {
            string randomFood, RandomDrink, randomMovie;
            randomFood = GetRandomFromFile("foods.txt");
            RandomDrink = GetRandomFromFile("drinks.txt");
            randomMovie = GetRandomFromFile("movies.txt");

            Console.WriteLine($"Tonight you will have some {randomFood} with {RandomDrink} and watch {randomMovie} ");

           
            
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}

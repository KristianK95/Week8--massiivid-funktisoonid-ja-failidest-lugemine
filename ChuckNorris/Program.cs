using System;
using System.IO;

namespace ChuckNorris
{
    class Program
    {
        static void Main(string[] args)
        {
            string randomQuote;
            randomQuote = GetRandomFromFile("chuck.txt");
            Console.WriteLine($"{randomQuote}");

            string filePath = @"C:\Users\...\Desktop\Samples\chuck.txt";

            string[] dataFromFile = File.ReadAllLines(filePath);
        }
        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            return randomIndex;
        }

        private static string GetRandomFromFile(string fileName)
        {
            string filePath = $@"C:\Users\...\Desktop\Samples\{fileName}";
            string[] dataFromFile = File.ReadAllLines(filePath);
            string randomElement = dataFromFile[GenerateRandomIndex(dataFromFile)];

            return randomElement;
        }
    }
}

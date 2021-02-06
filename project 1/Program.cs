using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sillyName = PromptUserForValue("What is your name?");
            string game = PromptUserForValue("What is your favorite game to play outside?");
            string tool = PromptUserForValue("Name a tool in your shop?");
            string adjective1 = PromptUserForValue("Type an adjective:");
            string playmate = PromptUserForValue("What did you eat for dinner last night?");
            string petName = PromptUserForValue("How do you prefer eggs cooked?");
            string pastTenseVerb = PromptUserForValue("Type a past tense verb that ends in -ed:");
            string place = PromptUserForValue("Name a place.");
            string verb1 = PromptUserForValue("Type an action verb.");

            Console.WriteLine("Press any key to see the story you made.");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("And now for our story...");
            Console.WriteLine($"One day, a young boy named {sillyName} was playing {game} using a {tool} with his {adjective1} friend {playmate}!");
            Console.WriteLine($"His pet {petName} came over and {pastTenseVerb} {playmate}.");
            Console.WriteLine($"Then {playmate} had to go to {place} to {verb1}!");

            Console.WriteLine("The END!");
        }

        private static string PromptUserForValue(string question)
        {
            ConsoleColor originalForegroundColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(question);
            Console.ForegroundColor = ConsoleColor.White;
            string result = Console.ReadLine();

            Console.ForegroundColor = originalForegroundColor;

            return result;
        }
    }
}

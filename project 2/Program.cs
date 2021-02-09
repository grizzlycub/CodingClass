using System;

namespace project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string verbIng1 = PromptUserForValue("Type an action verb ending in -ing.");
            string adjective1 = PromptUserForValue("Type an adjective.");
            string verbIng2 = PromptUserForValue("Type an action verb ending in -ing.");
            string partOfBody1 = PromptUserForValue("Name a part of your body.");
            string adverb = PromptUserForValue("Type an adverb (e.g. faintly).");
            string partOfBody2 = PromptUserForValue("Name a part of your body.");
            string noun = PromptUserForValue("Type a noun");
            string verb = PromptUserForValue("Type a verb");
            string animals = PromptUserForValue("Type an animal but it has to be plural");
            string color = PromptUserForValue("Type a color");
            string adjective = PromptUserForValue("Type  an ajective");
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine($"BIKE RIDING!!!");
            Console.WriteLine($"Most doctors agree that bicycle {verbIng1} is a/an {adjective1} form of exercise.");
            Console.WriteLine($"{verbIng2} a bicycle enables you to develop your {partOfBody1} muscles as well as {adverb} increase the rate of your {partOfBody2} beat.");
            Console.WriteLine($"More {noun} around the world {verb} bicycles than drive {animals}  ");
            Console.WriteLine($"No mater what kind of {noun} you {verb} allways be shure to ware a {adjective} helmet.");
            Console.WriteLine($"Make sure to have {color} reflectors too !");
            Console.WriteLine($"The end");
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

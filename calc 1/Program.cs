using System;

namespace calc_1
{
    class Program
    {
        private enum Operator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator!!!!!!!!!!!!");
            Console.WriteLine("I help with math!!");
            Console.WriteLine("I'm going to ask you for numbers and operators.");
            Console.WriteLine("Ready??");

            long firstNum = AskForANumber();
            Operator operation = AskForAnOperator();
            long secondNum = AskForANumber();

            long result = 0;
            char opChar = '~';
            checked
            {
                switch (operation)
                {
                    case Operator.Addition:
                        result = firstNum + secondNum;
                        opChar = '+';
                        break;

                    case Operator.Subtraction:
                        result = firstNum - secondNum;
                        opChar = '-';
                        break;

                    case Operator.Multiplication:
                        result = firstNum * secondNum;
                        opChar = 'x';
                        break;

                    case Operator.Division:
                        result = firstNum / secondNum;
                        opChar = '/';
                        break;
                }
            }

            Console.WriteLine($"{firstNum:N0} {opChar} {secondNum:N0} = {result:N0}");
        }

        private static long AskForANumber()
        {
            Console.WriteLine("Type a number:");
            string input = Console.ReadLine();

            long value = 0;
            while (!long.TryParse(input, out value))
            {
                Console.WriteLine($"Sorry, {input} is not a valid number. Try again!");
                input = Console.ReadLine();
            }

            return value;
        }

        private static Operator AskForAnOperator()
        {
            Console.WriteLine("Specify your operation: +, -, x, /");
            ConsoleKeyInfo input;
            
            while (true)
            {
                input = Console.ReadKey(true);

                switch (input.KeyChar)
                {
                    case '+':
                        return Operator.Addition;
                    case '-':
                        return Operator.Subtraction;
                    case 'x':
                        return Operator.Multiplication;
                    case '/': 
                        return Operator.Division;
                    default:
                        Console.WriteLine($"Operator {input.KeyChar} is not valid. Please type one of: +, -, x, /");
                        continue;
                }
            }
        }
    }
}

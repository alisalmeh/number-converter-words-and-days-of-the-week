using System;

namespace AliSalmeh_ProjectWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            PrintMenu();

            var input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                ConvertNumberToAlphabet();
            }

        }

        public static void ConvertNumberToAlphabet()
        {
            Console.WriteLine("Enter a number between 1 to 10: ");
            var numToAlphInput = Convert.ToInt32(Console.ReadLine());

            var numberToWord = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            var result = (numToAlphInput >= 1 && numToAlphInput <= 10) ? $"{numberToWord[numToAlphInput - 1]}" : "You entered out of range!";
            Console.WriteLine($"--> Result: {result}");
        }

        public static void PrintMenu()
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("Enter a number to execute:\n" +
                                "1) Convert number to alphabet\n" +
                                "2) Convert number to day of week\n" +
                                "3) Exit");
            Console.Write("--> ");
        }
    }
}

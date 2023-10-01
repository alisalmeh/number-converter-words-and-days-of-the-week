using System;

namespace AliSalmeh_ProjectWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;
            do
            {
                Console.Clear();
                PrintMenu();

                var input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    ConvertNumberToAlphabet();
                }
                else if (input == 2)
                {
                    ConvertNumberToDay();
                }
                else if (input == 3)
                {
                    runAgain = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You entered wrong item.\n Try again.");
                }

                var backToMenu = Console.ReadLine();

            } while (runAgain);
            
            Console.Clear();
            Console.WriteLine("Good Bye!");
        }

        public static void ConvertNumberToDay()
        {
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 7 for days of the week: ");
            var numToDayInput = Convert.ToInt32(Console.ReadLine());

            var daysOfWeek = new string[] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            if (numToDayInput >= 1 && numToDayInput <= 7)
            {
                string result = $"{daysOfWeek[numToDayInput - 1]}";
                Console.WriteLine($"--> Today is {result} :)");
            }
            else
            {
                Console.WriteLine("You entered out of range!");
            }
        }

        public static void ConvertNumberToAlphabet()
        {
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 10: ");
            var numToAlphInput = Convert.ToInt32(Console.ReadLine());

            var numberToWord = new string[] { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };

            if (numToAlphInput >= 1 && numToAlphInput <= 10)
            {
                string result = $"{numberToWord[numToAlphInput - 1]}";
                Console.WriteLine($"--> Result: {result}");
            }
            else
            {
                Console.WriteLine("You entered out of range!");
            }
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

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

                var input = GetUserInput();

                switch (input)
                {
                    case 1:
                        ConvertNumberToAlphabet();
                        break;
                    case 2:
                        ConvertNumberToDay();
                        break;
                    case 3:
                        runAgain = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("You entered wrong item.\n Try again.");
                        WaitForUserInput();
                        break;
                }
            } while (runAgain);

            Console.Clear();
            Console.WriteLine("Good Bye!");
        }

        public static void WaitForUserInput()
        {
            Console.ReadLine();
        }

        public static void ConvertNumberToDay()
        {
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 7 for days of the week: ");
            var numToDayInput = GetUserInput();

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

            WaitForUserInput();
        }

        public static void ConvertNumberToAlphabet()
        {
            Console.Clear();
            Console.WriteLine("Enter a number between 1 to 10: ");
            var numToAlphInput = GetUserInput();

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

            WaitForUserInput();
        }

        public static int GetUserInput()
        {
            Console.Write("--> ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintMenu()
        {
            Console.WriteLine("WELCOME");
            Console.WriteLine("Enter a number to execute:\n" +
                                "1) Convert number to alphabet\n" +
                                "2) Convert number to day of week\n" +
                                "3) Exit");
        }
    }
}

using System;

namespace AliSalmeh_ProjectWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            PrintMenu();


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

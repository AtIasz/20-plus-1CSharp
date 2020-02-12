using System;

namespace Nr_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = new string[] {"January","February",
                "March","April","May",
                "June","July","August",
                "September","October","November",
                "December"};
            Console.WriteLine("Input a number that represents a month.");
            string x = Console.ReadLine();
            int number = 0;

            bool canBeParsed = Int32.TryParse(x, out number);
            if (canBeParsed && number > 0 && number <= 12)
            {
                Console.WriteLine($"It is {Months[number-1]}.");
            }
            else
            {
                Console.WriteLine("Is not a valid integer || less than 0 || more than 12.");

            }
        }
    }
}

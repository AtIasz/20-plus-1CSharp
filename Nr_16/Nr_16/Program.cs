using System;

namespace Nr_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "Jotarosan";
            string input = "";
            for (int i = 0; i < 5; i++)
            {
                input = Console.ReadLine();
                if (input == password)
                {
                    Console.WriteLine("You are in.");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("You are not in.");
        }
    }
}

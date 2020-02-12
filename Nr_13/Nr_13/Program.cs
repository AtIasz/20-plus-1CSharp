using System;

namespace Nr_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in a month's name: ");
            string[] Winter = new string[] { "december", "january", "february" };
            string[] Spring = new string[] { "march","april","may"};
            string[] Summer = new string[] { "june","july","august"};
            string[] Autumn = new string[] { "september","october","december"};
            string nameOfMonth = Console.ReadLine();
            bool foundIt = false;
            for (int i = 0; i < Winter.Length; i++)
            {
                if (Winter[i]==nameOfMonth.ToLower())
                {
                    Console.WriteLine("It is in Winter");
                    
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < Spring.Length; i++)
            {
                if (Spring[i] == nameOfMonth.ToLower())
                {
                    Console.WriteLine("It is in Spring");
                    Environment.Exit(0);

                }
            }
            for (int i = 0; i < Summer.Length; i++)
            {
                if (Summer[i] == nameOfMonth.ToLower())
                {
                    Console.WriteLine("It is in Summer");
                    Environment.Exit(0);
                }
            }
            for (int i = 0; i < Autumn.Length; i++)
            {
                if (Autumn[i] == nameOfMonth.ToLower())
                {
                    Console.WriteLine("It is in Autumn");
                    Environment.Exit(0);
                }
            }
            if (!foundIt)
            {
                Console.WriteLine("It is not a month.");
            }

        }
    }
}

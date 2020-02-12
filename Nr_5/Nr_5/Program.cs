using System;

namespace Nr_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($" x + y = {x+y}");
            Console.WriteLine($" x - y = {x-y}");
            Console.WriteLine($" x * y = {x*y}");
            Console.WriteLine($" x / y = {x/y}");
        }
    }
}

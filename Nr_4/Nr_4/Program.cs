using System;

namespace Nr_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x>0)
            {
                Console.WriteLine("Positive number");
            }
            else
            {
                Console.WriteLine("Negative number");
            }
        }
    }
}

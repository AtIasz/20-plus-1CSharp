using System;

namespace Nr_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a boolean value: ");
            bool idk = Convert.ToBoolean(Console.ReadLine());
            if (idk == true)
            {
                Console.WriteLine("IGAZ");
            }
            else
            {
                Console.WriteLine("HAMIS");
            }
        }
    }
}

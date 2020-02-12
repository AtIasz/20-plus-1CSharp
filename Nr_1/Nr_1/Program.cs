using System;

namespace Nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the beam a value: ");
            double sheading = Convert.ToDouble(Console.ReadLine());
            double k = sheading / (2 * Math.PI);
            Console.Write($"The beam's sheading: {k}");
        }
    }
}

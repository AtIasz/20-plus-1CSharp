using System;

namespace Nr_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double hecto=0, liter=0, deci=0;
            double indec = Convert.ToDouble(Console.ReadLine());
            while (indec!=0)
            {
                if (indec - 100 >= 0)
                {
                    hecto += 1;
                    indec -= 100;
                    
                }
                else if (indec - 10 >= 0)
                {
                    liter += 1;
                    indec -= 10;
                    

                }
                else if (indec - 1 >= 0)
                {
                    deci += 1;
                    indec -= 1;

                }
            }
            Console.WriteLine($"Hecto: {hecto}, liter: {liter}, deci {deci}");
        }
    }
}

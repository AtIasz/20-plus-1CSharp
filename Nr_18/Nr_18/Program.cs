using System;

namespace Nr_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperature = new double[12];
            string tmptemp;
            for (int i = 0; i < temperature.Length; i++)
            {
                tmptemp = Console.ReadLine();
                double numeros = 0;

                bool canBeParsed = Double.TryParse(tmptemp, out numeros);
                if (canBeParsed)
                {
                    temperature[i] = numeros;
                }
                else
                {
                    Console.WriteLine("Is not a valid integer or less than 0.");
                    i--;

                }
                //temperature[i] = Convert.ToDouble(Console.ReadLine());

            }

            double avg = 0;
            for (int i = 0; i < temperature.Length; i++)
            {
                avg += temperature[i];

            }
            Console.WriteLine($"Average: {avg/temperature.Length}");
        }
    }
}

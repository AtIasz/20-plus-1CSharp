using System;

namespace Nr_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int numeros = 0;

            bool canBeParsed = Int32.TryParse(x, out numeros);
            if (canBeParsed && numeros>0)
            {
                int sum = 0;
                while (numeros > 0)
                {
                    sum++;
                    numeros = numeros / 10;
                }
                Console.WriteLine($"This number has {sum} digits.");
            }
            else
            {
                Console.WriteLine("Is not a valid integer or less than 0.");

            }
        }
    }
}

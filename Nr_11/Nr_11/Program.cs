using System;

namespace Nr_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a integer.\nI will check if the number is dividable by 9.");
            string x = Console.ReadLine();
            int numeros = 0;
            bool canBeParsed = Int32.TryParse(x, out numeros);
            if (canBeParsed)
            {
                int sum = 0;
                while (numeros > 0)
                {
                    sum += numeros % 10;
                    numeros = numeros / 10;
                }
                if (sum % 9 == 0)
                {
                    Console.WriteLine("Dividable");
                }
                else
                {
                    Console.WriteLine("Not dividable");
                }
            }
            else
            {
                Console.WriteLine("Is not a valid integer");

            }
            
        }
    }
}

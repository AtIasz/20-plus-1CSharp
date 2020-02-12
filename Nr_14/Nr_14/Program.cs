using System;

namespace Nr_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me the value of income: ");
            string x = Console.ReadLine();
            int income = 0;

            bool canBeParsed = Int32.TryParse(x, out income);
            if (canBeParsed && income > 0)
            {
                Console.Write("Give me the value of cost: ");
                string y = Console.ReadLine();
                int cost = 0;

                bool canBeParsedl = Int32.TryParse(y, out cost);
                if (canBeParsedl && cost > 0)
                {
                    int difference = income - cost;
                    if (difference>0)
                    {
                        Console.WriteLine("Profit");
                    }
                    else if (difference<0)
                    {
                        Console.WriteLine("Loss");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
                }
                else
                {
                    Console.WriteLine("Is not a valid integer or less than 0.");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Is not a valid integer or less than 0.");

            }

        }
    }
}

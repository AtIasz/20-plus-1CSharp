using System.Collections.Generic;
using System;

namespace Nr_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, bool> values = new Dictionary<string, bool>() { { "without glass", false }, { "double sugar", false }, { "foam", false } };
            Dictionary<string, bool> returning = new Dictionary<string, bool>();
            int price = 60;
            foreach (KeyValuePair<string,bool> kvp in values)
            {
                Console.WriteLine("Do you need "+kvp.Key +"?");
                string input = Console.ReadLine();
                if (input!="no")
                {
                    returning.Add(kvp.Key, true);
                    if (kvp.Key == "without glass")
                    {
                        price += 10;
                    }
                    else if (kvp.Key == "double sugar")
                    {
                        price += 20;
                    }
                    else if (kvp.Key =="foam")
                    {
                        price += 50;
                    }
                }
                else
                {
                    returning.Add(kvp.Key, kvp.Value);

                }
            }
            Console.WriteLine($"The price is {price} coins.");
            

        }
    }
}

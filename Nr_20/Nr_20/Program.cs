using System;
using System.Collections.Generic;
using System.Linq;

namespace Nr_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in an int value: ");
            string x = Console.ReadLine();
            int numeros = 0;
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>() { 
                { 47000,0},{20000,0}, {10000,0 }, {5000,0 }, {2000,0 }, {1000,0 }, {500,0 }, 
                {200,0 }, {100,0 }, {50,0 }, {20,0 }, {10,0 }, {5,0 }, {2,0 }, {1,0 } };
            bool canBeParsed = Int32.TryParse(x, out numeros);
            if (canBeParsed && numeros > 0)
            {
                int nig = 0;

                while (nig != numeros)
                {

                    foreach (int key in keyValuePairs.Keys.ToList())
                    {
                        if (nig + key <= numeros)
                        {
                            keyValuePairs[key] += 1;
                            nig += key;
                            
                        }
                    }
                }
                foreach (KeyValuePair<int,int> kvp in keyValuePairs)
                {
                    if (kvp.Value!=0)
                    {
                        Console.WriteLine($"{kvp.Key,5} has to be used {kvp.Value,3} times.");

                    }
                }
            }
            else
            {
                Console.WriteLine("Is not a valid integer or less than 0.");

            }
        }
    }
}

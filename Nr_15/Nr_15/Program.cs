using System;
using System.Collections.Generic;
using System.Text;

namespace Nr_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> languages = new List<string>() { "Hungarian", "English", "Spanish", "Japanese" };
            string thisLang = "no";
            int i=0;
            for (i = 0; i < languages.Count; i++)
            {
                if (thisLang !="yes")
                {
                    Console.WriteLine($"Do you speak {languages[i]}? Answer yes/no");
                    thisLang = Console.ReadLine().ToLower();
                }
                else
                {
                    i--;
                    break;
                }
            }
            if (thisLang!="yes")
            {
                Console.WriteLine('\u2665');
            }
            else
            {
                if (i==0)
                {
                    Console.WriteLine("Szia!");
                }
                else if (i==1)
                {
                    Console.WriteLine("Hello.");
                }
                else if (i==2)
                {
                    Console.WriteLine("¿Qué onda?");
                }
                else
                {
                    Console.WriteLine("Moshi moshi!");
                }
            }
        }

    }
}

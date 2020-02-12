using System;

namespace Nr_56
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate c = new Calculate();
            
            c.Plus(2, 3);
            c.Minus(2, 3);
            c.Multiplication(2, 3);
            c.Division(2, 3);

        }
    }
}

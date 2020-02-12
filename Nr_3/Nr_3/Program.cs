using System;

namespace Nr_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] triangle = new int[3];
            for (int i = 0; i < triangle.Length; i++)
            {
                triangle[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(Editable(triangle));
        }
        static bool Editable(int[] t)
        {
            if (t[0]+t[1] >t[2] && t[0] + t[2] > t[1] && t[1] + t[2] > t[0])
            {
                return true;
            }
            return false;
        }
    }
}

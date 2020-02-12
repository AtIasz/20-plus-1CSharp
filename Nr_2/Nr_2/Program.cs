using System;

namespace Nr_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            CrescentSortAnIntArray(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void CrescentSortAnIntArray(int[] a)
        {
            int j, A;
            for (int i = 1 ; i < a.Length; i++)
            {
                A = a[i];
                j = i - 1;
                while (j>=0 && A<a[j])
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = A;
            }
        }
    }
}

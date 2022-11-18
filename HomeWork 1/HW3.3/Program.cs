using System;

namespace HW3
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
                
            int[] mas = new int[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            int first = Convert.ToInt32(Console.ReadLine()),
                second = Convert.ToInt32(Console.ReadLine()),
                third = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            if (third > 0)
            {
                for (; second - first >= 0; first += third)
                {
                    Console.WriteLine(mas[first]);
                }
            }
            else
            {
                for (; second - first >= 0; second += third)
                {
                    Console.WriteLine(mas[second]);
                }
            }


        }
    }
}
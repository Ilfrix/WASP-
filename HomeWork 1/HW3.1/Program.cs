using System;

namespace HW3
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine()),
                pQueue = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];

            for (int i = 0; i < n; i++)
            {
                mas[i] = Convert.ToDouble(Console.ReadLine());
            }

            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum += Math.Pow(mas[i], pQueue);
            }

            Console.WriteLine(Math.Pow(sum, (1.0 / pQueue)));

        }
    }
}
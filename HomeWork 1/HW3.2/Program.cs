using System;

namespace HW3
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine()),
                k = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[n];
            for (int i = 0; i < n; i++)  //заполняю массив 
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }



            for(int i = 0; i < n - 1; i++) //сортировка пузырьком
            {
                int count = 1;
                for(int j = 0; j < n - count; j++)
                {
                    if (mas[j] >= mas[j + 1])
                    {
                        int temp = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = temp;
                    }
                    count++;    
                }
            }

            Console.WriteLine();

            Console.WriteLine(mas[k]);
        }
    }
}
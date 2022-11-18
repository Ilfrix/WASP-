using System;

namespace HW1
{
    class Program
    {
        public static void Main()
        {
            for(int i = 3; i < 10; i++)
            {
                for(int j = 2; j < 9 && j < i; j++)
                {
                    for (int k = 1; k < 8 && k < j; k++)
                    {
                        for (int l = 0; l < 7 && l < k; l++)
                        {
                            Console.WriteLine(i * 1000 + j * 100 + k * 10 + l);
                        }
                    }
                }
            }
        }
    }
}

// просто увеличиваю каждую цифру на единиицу, соблюдая условия
// минимальное 4 значное число в данном случае - это 3210 -, а максимальное - 9876.
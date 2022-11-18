using System;
using System.Linq;

namespace HW1
{
    class Program
    {
        public static void Main()
        {
            int[,] mas = new int[3, 2];

            // заполнение двумерного массива координатами
            for (int i = 0; i < 3; i++)
            {
                int FirstY = Convert.ToInt32(Console.ReadLine());
                int SecondY = Convert.ToInt32(Console.ReadLine());

                mas[i, 0] = FirstY; mas[i, 1] = SecondY;
            }

            //проверка на существование треугольника с заданными координатами
            double Length1 = 0, Length2 = 0, Length3 = 0;
            Length1 = Math.Pow(Math.Pow(mas[0, 0] - mas[1, 0], 2) + Math.Pow(mas[0, 1] - mas[1, 1], 2), 0.5); //нахожу длины сторон 
            Length2 = Math.Pow(Math.Pow(mas[1, 0] - mas[2, 0], 2) + Math.Pow(mas[1, 1] - mas[2, 1], 2), 0.5);
            Length3 = Math.Pow(Math.Pow(mas[2, 0] - mas[0, 0], 2) + Math.Pow(mas[2, 1] - mas[0, 1], 2), 0.5);
            if (((Length1 + Length2) > Length3) && ((Length2 + Length3) > Length1) && ((Length3 + Length1) > Length2)) // проверяю условие существования треугольника
            {
                Console.WriteLine("Triangle is exist!");
            }
            else
            {
                Console.WriteLine("Triangle do not exist((");
                Environment.ExitCode = 0;
            }

            //дальше буду проходить по каждой ячейке в консоли в прямогуольнике, в который как бы вписан треугольник,
            //то есть его координата вершины, противоположной вершине по координате (0, 0), по х будет максимальное значение х из координат вершин треугольника, и также с координатойц y.
            int maxX = 0, maxY = 0;

            /*if (mas[0, 0] >= mas[1, 0] && mas[0, 0] >= mas[2, 0]) maxX = mas[0, 0];
            else if (mas[1, 0] >= mas[2, 0]) maxX = mas[1, 0];
            else maxX = mas[2, 0];

            if (mas[0, 1] >= mas[1, 1] && mas[0, 1] >= mas[2, 1]) maxY = mas[0, 1];
            else if (mas[1, 1] >= mas[2, 1]) maxY = mas[1, 1];
            else maxY = mas[2, 1];*/

            int[] mas1 = { mas[0, 0], mas[1, 0], mas[2, 0] };
            int[] mas2 = { mas[0, 1], mas[1, 1], mas[2, 1] };
            maxX = mas1.Max(); maxY = mas2.Max();

            for(int i = 0; i < maxX; i++)
            {
                for(int j = 0; j < maxY; j++)
                {
                    if ((        (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) *
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) *
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 (((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) < 0) &&
                                 (((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) < 0) &&
                                 (((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) < 0) 
                                 )
                                 ||
                                 (
                                 (((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) > 0) &&
                                 (((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) > 0) &&
                                 (((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) > 0)
                                 )
                         )
                        )
                    {
                        Console.SetCursorPosition(i, j + 10);
                        Console.Write('#');
                    }
                    
                }


                for(int k = 0; k < 10; k++)
                {
                    Console.WriteLine();
                }

            }

        }
    }
}
//из за символьного вывода в консоль треугольники вырисовываются прямопропорционально плохо величине тупого угла в нем(((

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
                int FirstY  = Convert.ToInt32(Console.ReadLine());
                int SecondY = Convert.ToInt32(Console.ReadLine());

                mas[i, 0] = FirstY; mas[i, 1] = SecondY;
            }

            // mas[0,0] = x1, mas[1,0] = x2, mas[2,0] = x3, mas[0,1] = y1, mas[1,1] = y2, mas[2,1] = y3;
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

            /*if (mas[0, 0] >= mas[1, 0] && mas[0, 0] >= mas[2, 0]) maxX = mas[0, 0]; //вычисляет максимум и минимум Х и У для вершины прямоугольника.
            else if (mas[1, 0] >= mas[2, 0]) maxX = mas[1, 0];
            else maxX = mas[2, 0];

            if (mas[0, 1] >= mas[1, 1] && mas[0, 1] >= mas[2, 1]) maxY = mas[0, 1];
            else if (mas[1, 1] >= mas[2, 1]) maxY = mas[1, 1];
            else maxY = mas[2, 1];*/

            int[] mas1 = { mas[0, 0], mas[1, 0], mas[2, 0] };  //вычисляю макисмум для координаты нижней правой вершины прямоугольника
            int[] mas2 = { mas[0, 1], mas[1, 1], mas[2, 1] };  
            maxX = mas1.Max(); maxY = mas2.Max();
            

            // в цикле прохожусь по каждой ячейке прямоугольника в консоли, и проверяю условие на вхождение точки с координатами текущей ячейки в треугольник.
            for (int i = 0; i <= maxX + 1; i++)
            {
                for (int j = 0; j <= maxY + 1; j++)
                {
                    if ((        (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) > 0 &&    //проверка имеет большое количество условий, что позволяет                                                                                                                   
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) > 0 &&    //строить более точные треугольники, сами условия я брал  с сайта:
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0      //https://planetcalc.ru/8108/
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) > 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) > 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) > 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) > 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) < 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) < 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) < 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) < 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) < 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) < 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) < 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) < 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) < 0
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
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) > 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) > 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) == 0
                                 )
                                 ||
                                 (
                                 ((mas[0, 0] - i) * (mas[1, 1] - mas[0, 1]) - (mas[0, 1] - j) * (mas[1, 0] - mas[0, 0])) == 0 &&
                                 ((mas[1, 0] - i) * (mas[2, 1] - mas[1, 1]) - (mas[1, 1] - j) * (mas[2, 0] - mas[1, 0])) == 0 &&
                                 ((mas[2, 0] - i) * (mas[0, 1] - mas[2, 1]) - (mas[2, 1] - j) * (mas[0, 0] - mas[2, 0])) > 0
                                 )
                         )
                        )
                    {
                        Console.SetCursorPosition(i, j + 7); //если текущая координата вошла в треуголник, то курсор перемещается на эту координату и отрисовыввает символ.
                        Console.Write("*");
                    }

                }
            }

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }

        }
    }
}
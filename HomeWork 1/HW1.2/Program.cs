using System;

namespace HW1
{
    class Program
    {
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 9 && n >= 0) // просто проверка на правильный ввод
            {
                for (int i = 0; i < n; i++) //иду по строкам
                {
                    int temp = n - i;
                    for (int j = 0; j < n; j++) //иду по стобцам
                    {
                        if (j < i) // если номер столбца элемента меньше номера строки, то элемент увеличивается, и наоборот
                        {
                            Console.Write(Convert.ToString(temp) + "  ");
                            ++temp;
                        }
                        else
                        {
                            Console.Write(Convert.ToString(temp) + "  ");
                            --temp;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine(); //после заполнения каждой строгки - переход на новою строку 
                }
            }
            else
            {
                Console.WriteLine("Your input is not correct");
            }
}
    }
}

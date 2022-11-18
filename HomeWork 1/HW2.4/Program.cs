using System;

namespace HW2
{
    class Proram
    {
        static void Main()
        {
            long Number = Convert.ToInt64(Console.ReadLine());
            int count = 1;

            while (count <= 4)
            {
                short temp = (short) (Number - ((Number >> 16) << 16) );  // я узнаю последний шорт, то есть шорт первого введеного числа.
                                                                      // (Number >> 16) тут убираю последний шорт, ((Number >> 16) << 16) тут,
                                                                      // чтобы узнать убранный шорт с помощью разницы, я добавляю нули к урезанному числу.
                Console.WriteLine(temp);                              // вывожу ту самую разницу
                Number = Number >> 16;                                // уменьшаю число, чтобы в след цикле узнать третье введеное число и тд
                count++;
            }

        }
    }
}
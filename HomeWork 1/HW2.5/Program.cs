using System;

namespace HW2
{
    class Program
    {
        static void Main()
        {
            long number = Convert.ToInt64(Console.ReadLine()), Answer = 0;
            int first = Convert.ToInt32(Console.ReadLine()) - 1, second = Convert.ToInt32(Console.ReadLine()) - 1;
            short[] mas = new short[8];

            for (int i = 0; i < 8; i++)                             // разбиение лонга на части по байту и занесение этих байт в массив
            {
                mas[i] = (short)(number - ((number >> 8) << 8));
                number = number >> 8;
            }

            short temp = mas[second];  // меняю местами байты в массиве
            mas[second] = mas[first];
            mas[first] = temp;

            for (int i = 7; i > 0; i--)   // делаю лонг из элементов массива, то есть из байтов
            {
                Answer = (Answer | mas[i]) << 8;
            }
            Answer = Answer | mas[0];

            Console.WriteLine(Answer);
        }
    }
}
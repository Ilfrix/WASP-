using System;

namespace HW2
{
    class Program
    {
        public static void Main()
        {
            short first = Convert.ToInt16(Console.ReadLine()),
            second = Convert.ToInt16(Console.ReadLine()),
            third = Convert.ToInt16(Console.ReadLine()),
            fourth = Convert.ToInt16(Console.ReadLine());
            
            long Answer = fourth << 16;           // сейчас fourth это 0000 .... fourth, поэтому добавляю  еще  16  нулей для шорта третього числа
            Answer = (Answer | third) << 16;      // чтобы в конец этого, получается, инта (32 нолика) добавить third, необходимо использовать побитовое ИЛИ.
            Answer = (Answer | second) << 16;     // тут все по аналогии с third, поскольку побитовый сдвиг создает нули.
            Answer = (Answer | first);

            Console.WriteLine(Answer);
            
        }
    }
}
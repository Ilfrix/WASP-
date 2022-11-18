using System;

namespace HW2
{
    class Program
    {
        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0, k = 0; //sum - что то вроде полиномиальной записи.

            while(n > 0) // иду по числу от самого маленького разряда к большему
            {
                if ((n & 1) == 1) sum = Math.Pow(10, k) + sum;
                k++;
                n = n >> 1; // <==> n =  n / 10 
            }
            
            Console.WriteLine(sum);
        }
    }
}
using System;

namespace HW2
{
    class Program
    {
        static double binaryCon(int n) // функция перевода  в 2сс с помощью битовых, взята из прошлой задачи
        {
            double sum = 0, k = 0; 

            while (n > 0)
            {
                if ((n & 1) == 1) sum = Math.Pow(10, k) + sum;
                k++;
                n = n >> 1;
            }

            return sum;
        }

        static int CountOfDigit(long n) // подсчитывает кол во цифр 
        {
            int count = 0;
            if (n == 0) return 1;
            while (n > 0)
            {
                count++;
                n = n / 10;
            }

            return count;
        }


        public static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine()); 
            int m = Convert.ToInt32(Console.ReadLine());
            int additional_number = 0; // третья переменная, ктоорая будет отвечать за "единицу в уме" при сложении 

            double Answer = 0, k = 0; // answer - ответ 
            long binaryN = Convert.ToInt64(binaryCon(n)); 
            long binaryM = Convert.ToInt64(binaryCon(m));
            

            int CountN = CountOfDigit(binaryN), CountM = CountOfDigit(binaryM); 
            long tempN = binaryN, tempM = binaryM; // сохраняю нынешние переменные в двоичной сс, поскольку долее они будут изменятся 

            
            while (true)                                                                                //цикл, в котором и происходит мэджик
            {
                long LastOfN = binaryN & 1, LastOfM = binaryM & 1; //сохраняю последнюю цифру 
                long SumOfNumbers = LastOfN ^ LastOfM ^ additional_number; // или - не хорошо подходит для операции сложения, поскольку (0 ^ 1 = 1,
                                                                           // 1 ^ 0 = 1, 1 ^ 1 = 0)

                if (SumOfNumbers == 0)                                                                          //блок условий,  при которых переменная, запоминающая единицу,
                {                                                                                               //равна 1 или 0. ТАБЛИЦА ИСТИННОСТИ В САМОМ НИЗУ. На ней основан этот блок.
                    if ((LastOfN == 0) && (LastOfM == 0) && (additional_number == 0)) additional_number = 0;             
                    else additional_number = 1;
                }
                else
                {
                    if ((LastOfN == 1) && (LastOfM == 1) && (additional_number == 1)) additional_number = 1;
                    else additional_number = 0;
                }

                if (SumOfNumbers == 1) Answer = Math.Pow(10, k) + Answer; //строю ответ в двоичной сс по такой же сехме, как в первом задании.
                k++;
                binaryM = binaryM / 10; binaryN = binaryN / 10; 

                if (binaryM == 0 && binaryN == 0 && additional_number == 0) break; //условие выхода
            }


            Console.WriteLine();                        //блок вывода в консоль, который из количества цифр в ответе, дописывает нужное количесвто нулей перед числом
            for (int i = 0; i < CountOfDigit(Convert.ToInt64(Answer)) - CountN; i++)
            {
                Console.Write("0");
            }
            Console.WriteLine(tempN);
            for (int i = 0; i < CountOfDigit(Convert.ToInt64(Answer)) - CountM; i++)
            {
                Console.Write("0");
            }
            Console.WriteLine(tempM); Console.WriteLine();
            for (int i = 0; i < CountOfDigit(Convert.ToInt64(Answer)); i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();

            Console.WriteLine(Answer);

        }
    }
}



/*  a   b 	additional(текущий)     F(SumOfNumbers) additional(в памяти)


    0   0   0                       0               0
    0   0   1                       1               0
    0   1   0                       1               0
    0   1   1                       0               1
    1   0   0                       1               0
    1   0   1                       0               1
    1   1   0                       0               1
    1   1   1                       1               1                  */
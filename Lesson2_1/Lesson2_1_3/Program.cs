using System;

namespace Lesson2_1_3
{
    class Program
    {
        //3.Реализуйте функцию вычисления числа Фибоначчи
        static void Main(string[] args)
        {
            //цикл Фибоначчи
            int Fibon = 1;
            int f1 = 0;
            int f2 = 1;
            int fi = 0;
            Console.WriteLine($"Число Фибоначчи {Fibon}");
            for (int i = 0; i < Fibon; i++)
            {
                fi = f1 + f2;
                f1 = f2;
                f2 = fi;
                Console.WriteLine($"{i+1}:{fi}");
            }
            //рекурсия
            Console.WriteLine(FibonacciNum(5));

        }
        static uint FibonacciNum(uint n)
        {
            return (n == 0 || n == 1)
                ? 1
                : FibonacciNum(n - 1) + FibonacciNum(n - 2);
        }
    }
}

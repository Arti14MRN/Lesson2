using System;

namespace Lesson2_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Алгоритм вычисления простоты числа
            int number = 3;
            int i = 2;
            if (number % i == 0)
            {
                Console.WriteLine("сложное");
            }
            else
            {
                Console.WriteLine("простое");
            }
        }
    }
}


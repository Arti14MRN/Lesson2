using System;

namespace Lesson2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Посчитайте сложность функции
            //    public static int StrangeSum(int[] inputArray)
            //    {
            //        int sum = 0;
            //        for (int i = 0; i < inputArray.Length; i++) //O(N)
            //        {
            //            for (int j = 0; j < inputArray.Length; j++)//O(N)
            //            {
            //                for (int k = 0; k < inputArray.Length; k++)//O(N)
            //                {
            //                    int y = 0;

            //                    if (j != 0)
            //                    {
            //                        y = k / j;
            //                    }

            //                    sum += inputArray[i] + i + k + j + y;
            //                }
            //            }
            //        }

            //        return sum;
            //    }
            //
            //   
            Console.WriteLine("сложность функции составляет O(N^3)");
        }
    }
}

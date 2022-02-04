//Написать программу, выводящую элементы двухмерного массива по диагонали.

using System;

namespace Lesson_3_Task_1
{
    class Diagonal
    {
        static void Main(string[] args)
        {
            int[,] twoDimensionalArray = new int[6, 6];

            for(int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for(int j = 0; j<twoDimensionalArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        twoDimensionalArray[i, j] = 1;
                        Console.Write(twoDimensionalArray[i, j] + " ");
                    } else
                    {
                        Console.Write(twoDimensionalArray[i, j] + " ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

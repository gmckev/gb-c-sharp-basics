using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_4
{
    class FIbonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number for Fibonacci calculation:");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumber(userInput));
            Console.ReadKey();
        }

        static int GetFibonacciNumber(int usersNumber)
        {
            if ((usersNumber == 0) || (usersNumber == 1))
            {
                return usersNumber;
            }
            else
                return GetFibonacciNumber(usersNumber - 1) + GetFibonacciNumber(usersNumber - 2);
        }
    }
}

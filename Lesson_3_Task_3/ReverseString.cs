using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_3
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any string:");
            string userInput = Console.ReadLine();

            for(int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
            Console.ReadKey();
        }
    }
}

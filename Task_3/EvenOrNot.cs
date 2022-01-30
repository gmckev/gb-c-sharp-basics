//Определить, является ли введённое пользователем число чётным.

using System;

namespace Task_3
{
    class EvenOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number:");
            int usersNumber = Convert.ToInt32(Console.ReadLine());

            if(usersNumber % 2 == 0)
            {
                Console.WriteLine("Entered number is Even");
            } else
            {
                Console.WriteLine("Entered number is Odd");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Task_2
{
    class PhoneBook
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2];

            for (int i = 0; i<phoneBook.GetLength(0); i++)
            {
                for(int j = 0; j<phoneBook.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Enter your name");
                        string name = Console.ReadLine();
                        phoneBook[i, 0] = name;
                    } else if(j == 1)
                    {
                        Console.WriteLine("Enter your phone or email");
                        string phoneOrEmail = Console.ReadLine();
                        phoneBook[i, 1] = phoneOrEmail;
                    }
                }
            }

            foreach(string entry in phoneBook)
            {
                Console.WriteLine(entry);
            }
            Console.ReadKey();
        }
    }
}

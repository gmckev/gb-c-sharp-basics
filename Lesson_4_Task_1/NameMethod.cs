using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_1
{
    class NameMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Mickevich", "Gleb", "Advertovich"));
            Console.WriteLine(GetFullName("Ivanov", "Ivan", "Ivanovich"));
            Console.WriteLine(GetFullName("Petrov", "Petr", "Petrovich"));
            Console.ReadKey();

        }

        static string GetFullName(string lastName, string firstName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }
    }
}

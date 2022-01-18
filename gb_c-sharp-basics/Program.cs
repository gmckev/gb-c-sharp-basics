using System;

namespace gb_c_sharp_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Today is {DateTime.Now}");
            Console.ReadKey();
        }
    }
}

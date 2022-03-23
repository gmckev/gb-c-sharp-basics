using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.username))
            {
                Console.WriteLine("Enter username:");
                Properties.Settings.Default.username = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.age.Equals(default))
            {
                Console.WriteLine("Enter age:");
                Properties.Settings.Default.age = int.Parse(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.occupation))
            {
                Console.WriteLine("Enter occupation:");
                Properties.Settings.Default.occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string username = Properties.Settings.Default.username;
            int age = Properties.Settings.Default.age;
            string occupation = Properties.Settings.Default.occupation;
            string greeting = Properties.Settings.Default.greeting;
            Console.WriteLine($"{greeting}: {username}, you are {age} years old and work as {occupation}");
            Console.ReadKey();
        }
    }
}

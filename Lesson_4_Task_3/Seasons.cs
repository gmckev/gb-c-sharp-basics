using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_Task_3
{
    enum Season {
        Winter,
        Spring,
        Summer,
        Autumn,
        WrongSeason
    }
    class Seasons
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number:");
            int userMonthInput = int.Parse(Console.ReadLine());
            PrintSeasonName(GetSeason(userMonthInput));
            Console.ReadKey();
        }

        static Season GetSeason(int monthNumber)
        {
            switch(monthNumber)
            {
                case 1:
                case 2:
                    return Season.Winter;
                    break;
                case 3:
                case 4:
                case 5:
                    return Season.Spring;
                    break;
                case 6:
                case 7:
                case 8:
                    return Season.Summer;
                    break;
                case 9:
                case 10:
                case 11:
                    return Season.Autumn;
                    break;
                case 12:
                    return Season.Winter;
                    break;
                default:
                    Console.WriteLine("Wrong month number. Please enter month number in a range between 1 and 12.");
                    break;
            }
            return Season.WrongSeason;
        }

        static void PrintSeasonName(Season inputSeason)
        {
            Console.WriteLine($"Season name is: {inputSeason}");
        }
    }
}

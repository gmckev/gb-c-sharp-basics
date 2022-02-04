// Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

using System;

namespace Task_5
{
    enum Months
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    class RainyWinter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month number:");
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            Months month = (Months)usersNumber;

            Console.WriteLine("Enter minimum month temperature:");
            float minTemp = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter maximum month temperature:");
            float maxTemp = float.Parse(Console.ReadLine());

            float averageTemp = (minTemp + maxTemp) / 2;

            switch (month)
            {
                case Months.January:
                    Console.WriteLine($"1 = {Months.January}");
                    if(averageTemp > 0)
                    {
                        Console.WriteLine("It's a rainy winter");
                    }
                    break;
                case Months.February:
                    Console.WriteLine($"2 = {Months.February}");
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("It's a rainy winter");
                    }
                    break;
                case Months.March:
                    Console.WriteLine($"3 = {Months.March}");
                    break;
                case Months.April:
                    Console.WriteLine($"4 = {Months.April}");
                    break;
                case Months.May:
                    Console.WriteLine($"5 = {Months.May}");
                    break;
                case Months.June:
                    Console.WriteLine($"6 = {Months.June}");
                    break;
                case Months.July:
                    Console.WriteLine($"7 = {Months.July}");
                    break;
                case Months.August:
                    Console.WriteLine($"8 = {Months.August}");
                    break;
                case Months.September:
                    Console.WriteLine($"9 = {Months.September}");
                    break;
                case Months.October:
                    Console.WriteLine($"10 = {Months.October}");
                    break;
                case Months.November:
                    Console.WriteLine($"11 = {Months.November}");
                    break;
                case Months.December:
                    Console.WriteLine($"12 = {Months.December}");
                    if (averageTemp > 0)
                    {
                        Console.WriteLine("It's a rainy winter");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong month number");
                    break;
            }

            Console.ReadKey();
        }
    }
}

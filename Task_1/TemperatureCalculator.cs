//Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.

using System;

namespace Task_1
{
    class TemperatureCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter today's minimum temperature:");
            float minTemp = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter today's maximum temperature:");
            float maxTemp = float.Parse(Console.ReadLine());

            float averageTemp = (minTemp + maxTemp) / 2;

            Console.WriteLine($"Today's average temperature per celcium = {averageTemp}");

            Console.ReadKey();
        }
    }
}

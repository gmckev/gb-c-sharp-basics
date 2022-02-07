using System;

namespace Lesson_4_Task_2
{
    class StringAddition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers with space delimiter:");
            string inputString = Console.ReadLine();
            Console.WriteLine(ParseStringToSumOfNumbers(inputString));
            Console.ReadKey();
        }

        static float ParseStringToSumOfNumbers(string inputString)
        {
            int lengthOfStringArray = inputString.Length;
            String currentNumber = "";
            bool isSpace = false;
            float sumOfAllNumbers = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] != ' ')
                {
                    currentNumber = currentNumber + inputString[i];
                    isSpace = false;
                }
                else
                {
                    isSpace = true;
                }
                if (isSpace || i == lengthOfStringArray - 1)
                {
                    sumOfAllNumbers += float.Parse(currentNumber);
                    currentNumber = "";
                }
            }
            return sumOfAllNumbers;
        }
    }
}

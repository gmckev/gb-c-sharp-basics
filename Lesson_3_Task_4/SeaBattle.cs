using System;

namespace Lesson_3_Task_4
{
    class SeaBattle
    {
        static void Main(string[] args)
        {
            string[,] gameDeck = {
                {"O", "O", "O", "X", "O", "O", "O", "O", "O", "O" },
                {"X", "O", "O", "X", "O", "O", "O", "O", "O", "O" },
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                {"O", "O", "O", "O", "X", "X", "X", "X", "X", "O" },
                {"O", "O", "X", "X", "X", "O", "O", "O", "O", "O" },
                {"O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
                {"X", "X", "O", "O", "O", "O", "O", "O", "O", "O" },
                {"O", "O", "X", "O", "O", "O", "O", "O", "X", "X" },
                {"O", "O", "X", "O", "O", "X", "O", "O", "O", "O" },
                {"O", "O", "X", "O", "O", "O", "O", "O", "O", "O" }
            };

            for (int i = 0; i < gameDeck.GetLength(0); i++)
            {
                for (int j = 0; j < gameDeck.GetLength(1); j++)
                {
                    Console.Write(gameDeck[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}

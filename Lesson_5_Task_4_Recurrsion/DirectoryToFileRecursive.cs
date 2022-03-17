using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Task_4
{
 
    internal class Class1
    {
        static void Main(string[] args)
        {
            string fileName = "recursion.txt";
            Console.WriteLine("Enter directory path:");
            string userInput = Console.ReadLine();
            SearchWithinDirectory(userInput, fileName);
        }

        static void SearchWithinDirectory(string inputDirectory, string fileName)
        {
            try
            {
                foreach (string file in Directory.GetFiles(inputDirectory))
                {
                    File.AppendAllLines(fileName, new[] { file });
                }

                foreach (string directory in Directory.GetDirectories(inputDirectory))
                {
                    SearchWithinDirectory(directory, fileName);
                }

                Console.WriteLine("Sucessfuly created file: " + fileName);
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }
    }
}

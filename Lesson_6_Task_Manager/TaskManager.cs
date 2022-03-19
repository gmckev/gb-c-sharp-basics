//Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и
//позволяет завершить указанный процесс. Предусмотреть возможность завершения процессов с
//помощью указания его ID или имени процесса.

using System;
using System.Diagnostics;

namespace Lesson_6_Task_Manager
{
    internal class TaskManager
    {
        static void Main(string[] args)
        {
            bool toContinue = true;
            while (toContinue){
                int userInput = ShowMenu();
                switch (userInput)
                {
                    case 0:
                        toContinue = false;
                        break;
                    case 1:
                        ShowAllProcesses();
                        break;
                    case 2:
                        KillProcessById();
                        break;
                    case 3: KillProcessByName();
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            }
            
        }
        static int ShowMenu()
        {
            Console.WriteLine("Choose command:");
            Console.WriteLine("1 - show all processes");
            Console.WriteLine("2 - kill process by ID");
            Console.WriteLine("3 - kill process by Name");
            Console.WriteLine("0 - to exit");

            int userInput = int.Parse(Console.ReadLine());

            return userInput;
        }

        static void ShowAllProcesses()
        {
            Process[] process = Process.GetProcesses();

            foreach(Process processItem in process)
            {
                Console.WriteLine($"{processItem.Id}    {processItem.ProcessName}");
            }
        }

        static void KillProcessById()
        {
            Console.WriteLine("Enter process ID:");
            int inputID = int.Parse(Console.ReadLine());
            Process[] process = Process.GetProcesses();

            foreach (Process processItem in process)
            {
                if(processItem.Id == inputID)
                {
                    processItem.Kill();
                    Console.WriteLine($"Process {processItem.ProcessName} with ID: {processItem.Id} was stopped");
                }
            }
        }

        static void KillProcessByName()
        {
            Console.WriteLine("Enter process Name:");
            string inputName = Console.ReadLine();
            Process[] process = Process.GetProcesses();

            foreach (Process processItem in process)
            {
                if (processItem.ProcessName.Equals(inputName))
                {
                    processItem.Kill();
                    Console.WriteLine($"Process {processItem.ProcessName} with ID: {processItem.Id} was stopped");
                }
            }
        }

    }
}

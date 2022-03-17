//Написать программу, которая при старте дописывает текущее время в файл «startup.txt».

string fileName = "startup.txt";
string currentTime = DateTime.Now.ToString("HH:mm:ss");
File.AppendAllLines(fileName, new[] {currentTime});
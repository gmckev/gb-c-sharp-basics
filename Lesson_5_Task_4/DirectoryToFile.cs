//Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без.

Console.WriteLine("Enter directory path");
string userDirectoryPath = Console.ReadLine();

string[] entries = Directory.GetFileSystemEntries(userDirectoryPath, "*", SearchOption.AllDirectories);

string fileName = "pathToFile.txt";
File.WriteAllLines(fileName, entries);


string[] file = File.ReadAllLines(fileName);

foreach (string entry in file)
{
    Console.WriteLine(entry);
}



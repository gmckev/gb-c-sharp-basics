// Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.

Console.WriteLine("Enter any text");
string userInput = Console.ReadLine();
string fileName = "new.txt";
File.WriteAllText(fileName, userInput);
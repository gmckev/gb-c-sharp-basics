//Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл

Console.WriteLine("Enter number sequence from 0 to 255 using space as delimiter");
string userInput = Console.ReadLine();

string[] numbersArray = userInput.Split(' ');
byte[] bytesArray = numbersArray.Select(Byte.Parse).ToArray();

string fileName = "bytes.bin";
File.WriteAllBytes(fileName, bytesArray);

byte[] fromFile = File.ReadAllBytes("bytes.bin");
foreach(byte b in fromFile)
{
    Console.WriteLine(b);
}
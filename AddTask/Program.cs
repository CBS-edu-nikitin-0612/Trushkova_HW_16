// See https://aka.ms/new-console-template for more information
using AddTask;
using System.Text;

Console.WriteLine("Hello, Teacher!");

Console.OutputEncoding = Encoding.Unicode;
Dictionary dictionary = new Dictionary();

Console.WriteLine(dictionary["книга"]);
Console.WriteLine(dictionary["дом"]);
Console.WriteLine(dictionary["ручка"]);
Console.WriteLine(dictionary["стол"]);
Console.WriteLine(dictionary["карандаш"]);
Console.WriteLine(dictionary["яблоко"]);
Console.WriteLine(dictionary["солнце"]);
Console.WriteLine(dictionary["яблуко"]);
Console.WriteLine(dictionary["table"]);
Console.WriteLine(dictionary["стіл"]);

Console.WriteLine(new string('-', 20));

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(dictionary[i]);
}
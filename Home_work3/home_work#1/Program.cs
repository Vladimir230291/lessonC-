/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число для проверки на палиндром: ");
string? numberStr = Console.ReadLine();

char[] numberRevers = numberStr!.ToArray();

Array.Reverse(numberRevers);

if (numberStr == new string( numberRevers ))
    Console.WriteLine($"{numberStr} -> да");
else 
    Console.WriteLine($"{numberStr} -> нет");
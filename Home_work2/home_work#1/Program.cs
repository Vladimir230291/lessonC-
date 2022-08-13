//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначеное число: ");
string? numberStr = Console.ReadLine();
var number = int.Parse(numberStr!);

int firstDigit = number % 100;

int secondDigit = firstDigit / 10;

Console.WriteLine(secondDigit);
 
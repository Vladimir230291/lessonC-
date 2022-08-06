Console.WriteLine("Программа возведения в квадрат");
Console.WriteLine("Введите целое число ");

string? numberString = Console.ReadLine();

var number = int.Parse(numberString!);

int sqrt = number * number;

Console.WriteLine("Квардрат числа " + number + " есть число " + sqrt);
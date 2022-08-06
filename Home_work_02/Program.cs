//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 (целых) числа и программа покажет максимальное");
Console.Write("Введите первое число ");
string? numberSrt1 = Console.ReadLine();
var numberA = int.Parse(numberSrt1!);

Console.Write("Введите второе число ");
string? numberSrt2 = Console.ReadLine();
var numberB = int.Parse(numberSrt2!);

Console.Write("Введите третье число ");
string? numberSrt3 = Console.ReadLine();
var numberC = int.Parse(numberSrt3!);

int max = numberA;

if (max < numberB)    max = numberB;

else if (max < numberC)  max = numberC;

else Console.WriteLine("Введены не верные значения");

Console.WriteLine("Максимальное число " + max);
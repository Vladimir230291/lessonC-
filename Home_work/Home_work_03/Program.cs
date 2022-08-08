// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число ");
string? numberStr = Console.ReadLine();
var number = int.Parse(numberStr!);

double rest = number % 2;

if (rest == 0){
    Console.WriteLine("Число четное");
}
else {
    Console.WriteLine("Число не четное");
}
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите положительное число ");
string? numberStr = Console.ReadLine();
var number = int.Parse(numberStr!);

double rest;
if (number > 0){
    Console.WriteLine("Четные числа");
for (int i = 1; i <= number; i++){
    rest = i % 2;
    if (rest == 0){
        Console.Write($" {i}");
    }
}
}
else {
    Console.WriteLine("Введено не верное число");
}
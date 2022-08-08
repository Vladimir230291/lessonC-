//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Программа определяет наибольшее число из 2ух введеных");

Console.WriteLine("Введите первое число");
string? numberSrt1 = Console.ReadLine();
var numberA = int.Parse(numberSrt1!);

Console.WriteLine("Введите второе число");
string? numberSrt2 = Console.ReadLine();
var numberB = int.Parse(numberSrt2!);

if (numberA > numberB){
    Console.WriteLine("Первое число '" + numberA + "' больше второго '" +  numberB + "'");
}
else if (numberA == numberB){
    Console.WriteLine("Числа равны");
}
else{
    Console.WriteLine("второе число '" + numberB + "' больше первого '"+  numberA + "'");
}
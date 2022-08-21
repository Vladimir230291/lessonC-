// //Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
// var number = int.Parse(Console.ReadLine()!);

// if (number <= 0)
//     return;

// var result = SumFrom1ToA(number);


// Console.WriteLine(result);


// int SumFrom1ToA(int a){
    // int result = 0;

    // for(var i = 1; i <= a; i++){
    //     result += i;
    // }
    // return result;

// Console.WriteLine("Введите число");
// String? numberStr = Console.ReadLine();

// if (int.TryParse(Console.ReadLine(), out var number)){
// }
//     if (number <= 0)
//         return;

// int lenght = numberStr!.Length;

// Console.WriteLine($"Длина числа {lenght} символов");

// if (int.TryParse(Console.ReadLine()!, out var number)) 
// { 
// if (number < 0) 
// return; 

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 4 -> 24 5 -> 120 


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0] 

int[] CreateArray()
{
Console.WriteLine("Программа для вывода 8 элементов");

int[] array = new int[8];
var random = new Random();

for (int i = 0; i < 8; i++)
    array[i] = random.Next(0,2);

return array;
}

var array = CreateArray;

for (int i = 0; i < 8; i++)
Console.WriteLine($"{array}");

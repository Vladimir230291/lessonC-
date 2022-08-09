/*11. Напишите программу, которая выводит случайное трёхзначное
 число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

/*int randomNumber =  new Random().Next(100,999);

int firstDigit = randomNumber / 100;
int thirdDigit = randomNumber % 10;
Console.WriteLine(randomNumber);
Console.Write(firstDigit);
Console.Write(thirdDigit);*/

/* 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно */

/*Console.WriteLine("Введите первое число: ");
string? numberFirstStr = Console.ReadLine();
var numberFirst = int.Parse(numberFirstStr!);

Console.WriteLine("Введите второе число: ");
string? numberSecondStr = Console.ReadLine();
var numberSecond = int.Parse(numberSecondStr!);

int ostatok = numberFirst%numberSecond;

if (ostatok == 0)
    Console.WriteLine("Кратно");
else {
    Console.Write("не кратно, ");
    Console.WriteLine("Остаток: " + ostatok);
}*/

/*14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/*Console.WriteLine("Введите число: ");
string? numberStr = Console.ReadLine();
var number = int.Parse(numberStr!);

if (number % 7 == 0 && number % 23 == 0)
    Console.WriteLine("да");
else{
    Console.WriteLine ("нет");
}*/

/*16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет*/

/*Console.WriteLine("Введите первое число: ");
string? numberFirstStr = Console.ReadLine();
var numberFirst = int.Parse(numberFirstStr!);

Console.WriteLine("Введите второе число: ");
string? numberSecondStr = Console.ReadLine();
var numberSecond = int.Parse(numberSecondStr!);

int sqrt1 = numberFirst * numberFirst;
int sqrt2 = numberSecond * numberSecond;

if (sqrt1 == numberSecond | sqrt2 ==numberFirst)
    Console.WriteLine("да");
else {
    Console.WriteLine("Нет");
} */
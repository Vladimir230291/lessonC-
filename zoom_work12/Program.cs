// Задача 63: Задайте значение N. Напишите программу, к
// оторая выведет все натуральные числа в промежутке от 1 до N. N = 5 -> "1, 2, 3, 4, 5" N = 6 -> "1, 2, 3, 4, 5, 6" 
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 6, 7, 8" 

void PrintNaturalNumber(int n)
{
    if (n < 1) return;
    if (n == 1) Console.Write($"{n} ");
    else
    {
        PrintNaturalNumber(n - 1);
        Console.Write($"{n} ");
    }
}
int n = 6;
PrintNaturalNumber(n);

// / Задача 65: 
// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// M = 4; N = 8 -> "4, 6, 7, 8" 

// void PrintNaturalNumber(int m, int n)
// {
//     if (m == n) Console.Write($"{n} ");
//     else
//     {
//         Console.Write($"{m} ");
//         PrintNaturalNumber(m + 1, n);
//     }
// }

// int m = 4;
// int n = 18;
// PrintNaturalNumber(m, n);
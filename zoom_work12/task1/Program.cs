// Задача 67: 
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 
// 453 -> 12 
// 45 -> 9 


// int SumDigits(int n)
// {
//     if (n / 10 != 0)
//         return n % 10 + SumDigits(n / 10);
//     else
//         return n % 10;
// }

// Console.WriteLine(SumDigits(453));



// Задача 69: 
// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) 
// A = 2; B = 3 -> 8 


// int PowerRec(int a, int n)
// {
//     // return n == 0 ? 1 : PowerRec(a, n - 1) * a; // сокращенный способ записи двух следующих строк 
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }

// Console.WriteLine(PowerRec(2, 10));
//Задача 39: Напишите программу,  которая перевернёт одномерный массив  (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// int[] ReverseArray(int[] input) { int[] result = new int[input.Length]; for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--) { result[i] = input[j]; } return result; }
// void PrintArray(int[] input) { for (var i = 0; i < input.Length; i++) Console.Write(input[i] + ", "); }
// int[] input = new int[] { 1, 2, 3, 4, 5 }; var result = ReverseArray(input); PrintArray(result);


// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины. Теорема о неравенстве треугольника: 
// каждая сторона треугольника меньше суммы двух других сторон.
// bool IsTriangleExist(int A, int B, int C)
// { 
// if (A < B + C && B < A + C && C < B + A) { 
//     return true; 
//     } 
//     return false; 
//     }
// Console.Clear(); Console.WriteLine("Enter A"); int A = int.Parse(Console.ReadLine()!);
//  Console.WriteLine("Enter B"); int B = int.Parse(Console.ReadLine()!); Console.WriteLine("Enter C");
//   int C = int.Parse(Console.ReadLine()!); if (IsTriangleExist(A, B, C)) 
//   { Console.WriteLine("Да."); } else { Console.WriteLine("Нет."); }

//из десятичного в двоичное

// Решение в группах задач:
// Задача 44:
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1. Если N = 5 -> 0 1 1 2 3 Если N = 3 -> 0 1 1 Если N = 7 -> 0 1 1 2 3 5 8 
// Задача 45: 
// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования. 
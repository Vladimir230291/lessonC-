// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите количество строк(м)");
if (!int.TryParse(Console.ReadLine()!, out int m))
{
    Console.WriteLine("Введите число!");
}
Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Введите число!");
}
Console.WriteLine("Введите в какой строке искать");
if (!int.TryParse(Console.ReadLine()!, out int mSearch))
{
    Console.WriteLine("Введите число!");
}
Console.WriteLine("Введите в каком столбце искать");
if (!int.TryParse(Console.ReadLine()!, out var nSearch))
{
    Console.WriteLine("Введите число!");
}

int[,] CreateRandomArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);

        }
    }
    return array;
}

void PrintArray(int[,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] array = CreateRandomArray(m, n);

PrintArray(array);
Console.WriteLine();

if (mSearch > 0
    && mSearch <= m
    && nSearch > 0
    && nSearch <= n)

    Console.WriteLine(array[mSearch - 1, nSearch - 1]);

else
    Console.WriteLine("Такого элемента нет");

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
int[,] SortElementOfArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

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

int[,] array = CreateRandomArray(m, n);
PrintArray(array);
int[,] sortArray = SortElementOfArray(array);
PrintArray(sortArray);
/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9.*/


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

double[,] CreateRandomArray(int m, int n)
{
    double[,] array = new double[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.NextDouble()* random.Next(10,20) - random.Next(1,10);

        }
    }
    return array;
}

void PrintArray (double[,] array){

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j].ToString("F1")}, ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
PrintArray(CreateRandomArray(m,n));
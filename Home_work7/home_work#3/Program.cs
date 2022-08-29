// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double[] CalculatingArithmeticMeanColumn(int[,] arr, int n)
{
    double[] arraySum = new double[n];
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arraySum[j] += arr[i,j];
            
        }

    }
    for (int i = 0; i < arraySum.Length; i++)
    {
        arraySum[i] /= n;
    }

    return arraySum;
}
void PrintResultArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i].ToString("F1")}, ");
    }
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
Console.WriteLine();
int[,] array = CreateRandomArray(m, n);
PrintArray(array);
double[] arithmeticMeanArray = CalculatingArithmeticMeanColumn(array, n);
PrintResultArray(arithmeticMeanArray);
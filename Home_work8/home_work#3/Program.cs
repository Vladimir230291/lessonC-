// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRandomArray(int n)

{
    int[,] array = new int[n, n];

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
int[,] CalculationMatrixProduct(int[,] array, int[,] array2)
{
    int[,] resultMatrix = new int[array.GetLength(0), array2.GetLength(1)];


    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultMatrix[j, k] += array[i, k] + array2[k, j];
            }
        }
    }
    return resultMatrix;
}

Console.WriteLine("Введите размер матрицы");
if (!int.TryParse(Console.ReadLine()!, out int n))
{
    Console.WriteLine("Введите число!");
}

int[,] array1 = CreateRandomArray(n);
int[,] array2 = CreateRandomArray(n);
PrintArray(array1);
PrintArray(array2);
PrintArray(CalculationMatrixProduct(array1, array2));

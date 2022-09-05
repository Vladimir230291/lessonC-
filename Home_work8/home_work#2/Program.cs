// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[] SumStringArray(int[,] arr)
{
    int[] result = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[i] = result[i] + arr[i, j];
        }
    }
    return result;

}
int FindMinSringArray(int[] arr)
{
    int minStr = arr[0];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minStr)
        {
            minStr = arr[i];
            index = i;
        }
    }



    return index;
}


Console.WriteLine("Введите число столбцов");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Введите число!");
}

int[,] randomArray = CreateRandomArray(n);
PrintArray(randomArray);
foreach (int i in SumStringArray(randomArray))
{
    Console.WriteLine("{0}", i);
}
int[] randomArraySum = SumStringArray(randomArray);
int findString = FindMinSringArray(randomArraySum);
Console.WriteLine("строка с найменьшей суммой элементов " + (findString + 1));

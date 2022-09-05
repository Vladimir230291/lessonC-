// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. 
/*

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

int[,] SwapArray(int[,] array)
{

    int[,] resultArray = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[array.GetLength(0)-1, j];

            if (i != 0 && i != array.GetLength(0)-1)

                resultArray[i, j] = array[i, j];

            if (i == 0)

                resultArray[i, j] = temp;

            else if (i == array.GetLength(0)-1)

            {
                resultArray[i, j] = array[i, j];

            }


        }
    }
    return resultArray;
}

Console.WriteLine();
var array = CreateRandomArray(m, n); 
PrintArray(array);
Console.WriteLine(); 
PrintArray(SwapArray(array));*/

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных. 
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 1 встречается 1 раз 2 встречается 1 раз 8 встречается 1 раз 9 встречается 3 раза

// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
//  Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 5 2 6 7 Наименьший элемент - 1, 
//  на выходе получим следующий массив: 9 2 3 4 2 4 2 6 7    

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

int SearchMinElenet(int[,] array){

    int min = array[0,0];
    int[,] index = new int[0,0];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
                    

            while (array[i,j]<min)
            {
                min = array[i,j];
                if (min == array[i,j])
                index[i,j] = array[i,j];
            }
            
        }

    }
    Console.WriteLine(min);
    return min;
}
int[,] arr = CreateRandomArray(n,m);
PrintArray(arr);
int min = SearchMinElenet(arr);



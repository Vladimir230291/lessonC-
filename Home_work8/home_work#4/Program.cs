// ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1);

int[,,] CreateRandom3DArray(int n)

{
    int[,,] array = new int[n, n, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = random.Next(0, 100);
            }

        }
    }
    return array;
}
void Print3DArray(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"{array[i, j, l]}{(i, j, l)}, ");
            }
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}
while (true)
{
    Console.Write("Введите размер техмерного массива либо 0 что бы завершить программу: ");

    if (!Int32.TryParse(Console.ReadLine(), out int n) || n <= 0) break;

    int[,,] array = CreateRandom3DArray(n);
    Print3DArray(array);
}

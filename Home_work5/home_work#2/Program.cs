// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Программа создаст массив со случайными числами и найдет сумму элементов на нечетной позиции");
Console.WriteLine("Введите длину создаваемого массива");
string? arrLeg = Console.ReadLine();
bool success = int.TryParse(arrLeg, out int length);

void RandomArr(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 99);
    }
}
int SumElemNotEven(int[] col)
{
    int count = 0;
    for (int i = 1; i < col.Length; i += 2)
    {
        count += col[i];
    }
    return count;
}
void WriteArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("---> ");
}

if (success && length > 0)
{
    int[] array = new int[length];
    RandomArr(array);
    WriteArr(array);
    var result = SumElemNotEven(array);
    Console.WriteLine(result);
}
else Console.WriteLine("Введите целое положительно число");
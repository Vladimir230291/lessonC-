// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// коментарий от себя: решил сделать массив рандомных чисел в диапозоне до 100, длину пользователь устанавливает сам,
// так как условия задачи не совсем конкретны.

Console.WriteLine("Введите длину создаваемого массива");
string? len = Console.ReadLine();
bool success = int.TryParse(len, out int lengthArr);

void RandomArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}
int MaxArrayElement(int[] arr)
{
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
int MinArrayElement(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i} Элемент содержит: {arr[i]}");
    }
}

int[] array = new int[lengthArr];

if (success && lengthArr > 0)
{
RandomArr(array);
PrintArray(array);
int maxElement = MaxArrayElement(array);
int minElement = MinArrayElement(array);
Console.WriteLine($"max {maxElement}");
Console.WriteLine($"min {minElement}");
Console.WriteLine($"разница между макс. и мин.: {maxElement - minElement}");
}
else Console.WriteLine("Некоректно ввели длину массива");
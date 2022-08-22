// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.WriteLine("Программа создаст случайный массив из трехзначных чисел ");
Console.WriteLine("Введите длину массива");
string? massStr = Console.ReadLine();

bool success = int.TryParse(massStr, out int masslg);

void RandomArr(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}
int EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void WriteArr(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}



if (success && masslg > 0)
{

    int[] array = new int[masslg];
    RandomArr(array);
    int result = EvenNumber(array);

    Console.WriteLine("Созданный массив содержит:");

    WriteArr(array);
    Console.WriteLine($"четных чисел: {result}");
}
else Console.WriteLine("Ошибка ввода. Введите целое положительное число");
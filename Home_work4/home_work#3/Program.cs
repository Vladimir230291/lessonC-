// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void EnterArray(string[] arr)
{
   
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine();
        Console.WriteLine($"Введите {i + 1} элемент массива");
        string? elem = Console.ReadLine();
        arr[i] = elem!;

    }
    


}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine();
}

string[] array = new string [8];

EnterArray(array);
Console.WriteLine("Содержимое массива");
PrintArray (array);
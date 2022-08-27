// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 

void InputNumber(int N, int[] arr)
{

    for (int i = 0; i < N; i++)
    {
        Console.WriteLine($"Введите {i + 1} число");
        string? numstr = Console.ReadLine();
        int num = int.Parse(numstr!);

        arr[i] = num;

    }
}
int HowManyNumGreatZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;

}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

Console.WriteLine("Какое количество чисел хотите ввести?");
string? countNumStr = Console.ReadLine();

if (int.TryParse(countNumStr, out int countNum))
{
    int[] array = new int[countNum];
    int count;

    InputNumber(countNum, array);
    PrintArray(array);

    Console.WriteLine($"---> {count = HowManyNumGreatZero(array)}");
}
else Console.WriteLine("Введите целое число ");
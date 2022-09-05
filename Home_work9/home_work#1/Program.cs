// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void PrintValue(int m, int n)
{
    if (m < n)
    {
        System.Console.Write($"{m++}, ");
        PrintValue(m, n);
    }
    else System.Console.WriteLine(n);
}
int InputNumbers()
{
    System.Console.WriteLine("Введите число");
    if (int.TryParse(Console.ReadLine(), out int num))
    {
        return num;
    }
    else Console.WriteLine(" некоректное значние ");
    return 0;
}

int a = InputNumbers();
int b = InputNumbers();
PrintValue(a, b);
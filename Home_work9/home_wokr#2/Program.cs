// Задача 66: Задайте значения m и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от m до n.
// m = 1; n = 15 -> 120
// m = 4; n = 8. -> 30

int Inputnumbers()

{
    Console.WriteLine("Введите целое число");
    if (int.TryParse(Console.ReadLine(), out int n));
    return n;
}

int SumNumbers(int m, int n, int sum = 0)
{
    if (m > n) return sum;
    else
    {
        sum += m;
        return SumNumbers(m + 1, n, sum);
    }
}
int a = Inputnumbers();
int b = Inputnumbers();
Console.WriteLine(SumNumbers(a, b));
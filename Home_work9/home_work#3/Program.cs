// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

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

int Akkerman(int m, int n)
{
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    if (m == 0) return n + 1;
    else Console.Write("не верное значение");
    return -1;
}

int a = InputNumbers();
int b = InputNumbers();
Console.WriteLine(Akkerman(a,b)); 

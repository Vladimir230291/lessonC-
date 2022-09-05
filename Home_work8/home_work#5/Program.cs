// Напишите программу, которая заполнит спирально массив 4 на 4.

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            Console.Write("{0,3}", a[i, j]);
        Console.WriteLine();
    }
}

void Main()
{
    while (true)
    {
        Console.Write("Введите размер матрицы либо 0 что бы завершить программу: ");

        int n;
        if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

        Console.WriteLine();

        int[,] a = new int[n, n];

        int i = 0, j = 0;

        int value = 1;

        while (n != 0)
        {
            int k = 0;
            do { a[i, j++] = value++; } while (++k < n - 1);
            for (k = 0; k < n - 1; k++)
                a[i++, j] = value++;
            for (k = 0; k < n - 1; k++)
                a[i, j--] = value++;
            for (k = 0; k < n - 1; k++)
                a[i--, j] = value++;
            ++i;
            ++j;
            if (n < 2) n = 0;
            else
                n = n - 2;
        }
        PrintArray(a);
    }
}
Main();
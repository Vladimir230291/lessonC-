// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число");
string? numberOne = Console.ReadLine();

Console.WriteLine("Введите натуральную степень числа");
string? numberTwo = Console.ReadLine();

bool success = int.TryParse(numberOne, out int number);
bool success2 = int.TryParse(numberTwo, out int power);

double Exponentiation(double A, int power)
{
    if (power == 0)
    {
        return 1;
    }
    double result = A;

    for (int i = 2; i <= power; i++)
    {
        result = result * A;
    }
    return result;
}

if (success && success2)
{
    double result1 = Exponentiation(number, power);
    Console.WriteLine(result1);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Введена не корректная степень числа");
}
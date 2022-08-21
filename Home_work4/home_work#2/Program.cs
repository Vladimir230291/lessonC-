//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("Введите число");
string? numberStr = Console.ReadLine();
// var number = int.Parse(numberStr!);

bool success = int.TryParse(numberStr, out int number);

int SumNumber(int num)
{
    
    int result = 0;

    while (num > 0)
    {
        result += num % 10;
        num = num / 10;
    }

    return result;
}

if (number < 0 ) number *= (-1);

if (success){
    int result = SumNumber(number);
    Console.WriteLine($"Сумма цифр в числе равна: {result}");
}
else {
    Console.WriteLine();
    Console.WriteLine("Введено не верное значение, введите число");
}    
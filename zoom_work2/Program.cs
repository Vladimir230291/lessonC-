Console.WriteLine("Введите первое число");
string? firstNumber = Console.ReadLine();
var Number1 = int.Parse(firstNumber!);

Console.WriteLine("Введите Второе число");
string? secondNumber = Console.ReadLine();
var Number2 = int.Parse(secondNumber!);

if (Number2 == Number1/Number2)
{
    Console.WriteLine("да");
}
else
 {
    Console.WriteLine("no");
}
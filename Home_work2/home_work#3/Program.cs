// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
string? numberStr = Console.ReadLine();
var number = int.Parse(numberStr!);

int week = 7;
int Saturday = 6;
int Sunday =7;

if (number <= week){
    if(number == Saturday)
        Console.WriteLine("Выходной");
    else if (number == Sunday)
        Console.WriteLine("Выходной");
    else
    {
        Console.WriteLine("Рабочий день");
    }
}
else{
    Console.WriteLine("Введите коректный день недели");
}
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое число число: ");
string? numberStr = Console.ReadLine();

char[] numberArray = numberStr!.ToArray();

    if (numberArray.Length < 3){
        Console.WriteLine("третьей цифры нет");
}
    else{
        Console.WriteLine(numberArray[2]);
}


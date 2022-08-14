// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое положительно число: ");
string? numberStr  = Console.ReadLine();
int number = int.Parse(numberStr!);

if (number > 0){
    for (int i = 1; i <= number; i++){
        double result = Math.Pow(i, 3);
        Console.Write(result);
        if (i != number) {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}
else Console.WriteLine("Введите положительно число!");

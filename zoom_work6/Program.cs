// Напишине программу, которая на вход принимает кооринаты точки(Х и Y), причем Х и У не равны 0 
// и выдает номер четверти плоскости в которой находиться эта точка.

/*Console.WriteLine("Введите координату Х: ");
var xString = Console.ReadLine();
int x = int.Parse(xString!);

if (x == 0){
    Console.WriteLine("Невозможно вычеслить четверть");
    return;
}
Console.WriteLine("Введите координату У: ");
var yString = Console.ReadLine();
int y = int.Parse(yString!);

if (y == 0){
    Console.WriteLine("Невозможно вычеслить четверть");
    return;
}
int result = 0;
if (x > 0 && y > 0)
    result = 1;
else if(x < 0 && y > 0)
    result = 2;
else if (x < 0 && y < 0)
    result = 3;
else if (x > 0 && y < 0)
    result =4;
//x > 0; y > 0 => первая четверть 
//x < 0; y > 0 => 2
//x < 0; y < 0 => 3
//x > 0; y < 0 => 4 чеверть
if (result != 0)
    Console.WriteLine("номер четверти, в которой находиться точка: " + result);
else
    Console.WriteLine("Ошибка. Не удалось вычислить номер четверти");*/
/*
Console.WriteLine("Введите номер четверти(1-4): ");
var xString = Console.ReadLine();
int x = int.Parse(xString!);

if (x == 0 || x > 4 || x < 0){
    Console.WriteLine("Введено не коректное значение");
    return;
}
else {

if (x == 1) Console.WriteLine("х = от 0 до бесконечности и у = от 0 до бесконечности");
else if (x == 2) Console.WriteLine("х = меньше 0 до бесконечности и у = от 0 до бесконечности");
else if (x == 3) Console.WriteLine("х = меньше 0 до бесконечности и у = меньше 0 до бесконечности");
else if (x == 4) Console.WriteLine("х = от 0 до бесконечности и у = меньше 0 до бесконечности");
}
*/

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние сежу ними
// в 2D пространстве.

/*Console.WriteLine("Введите координату Х для первой точки: ");
var x_1_String = Console.ReadLine();
int x_1 = int.Parse(x_1_String!);
Console.WriteLine("Введите координату Y для первой точки: ");
var y_1_String = Console.ReadLine();
int y_1 = int.Parse(y_1_String!);
Console.WriteLine("Введите координату Х для второй точки: ");
var x_2_String = Console.ReadLine();
int x_2 = int.Parse(x_2_String!);
Console.WriteLine("Введите координату Y для второй точки: ");
var y_2_String = Console.ReadLine();
int y_2 = int.Parse(y_2_String!);

float result = (float)Math.Sqrt((int)Math.Pow(x_2-x_1, 2) + (int)Math.Pow(y_2-y_1, 2));

Console.WriteLine($"расстояние межу точками равно: {result.ToString("N2")}");
*/

// Напишите программу которая принимает на вход число(Н) и дает таблицу краратов от 1 до (Н)

/*Console.WriteLine("Введите число : ");
var xString = Console.ReadLine();
int N = int.Parse(xString!);

if (N > 0){
    for (int i = 1; i < N; i++){
        double result = Math.Pow(i,2);
        Console.WriteLine($"крадрат числа {i} = {result}");
}}
else
    Console.WriteLine("Введите положительное число ");*/
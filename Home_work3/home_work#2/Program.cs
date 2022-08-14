// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х для первой точки: ");
var one_1_String = Console.ReadLine();
double one_coor_x = int.Parse(one_1_String!);
Console.WriteLine("Введите координату Y для первой точки: ");
var one_2_String = Console.ReadLine();
double one_coor_y = int.Parse(one_2_String!);
Console.WriteLine("Введите координату Z для первой точки: ");
var one_3_String = Console.ReadLine();
double one_coor_z = int.Parse(one_3_String!);
Console.WriteLine("Введите координату Х для первой точки: ");
var two_1_String = Console.ReadLine();
double two_coor_x = int.Parse(two_1_String!);
Console.WriteLine("Введите координату Y для второй точки: ");
var two_2_String = Console.ReadLine();
double two_coor_y = int.Parse(two_2_String!);
Console.WriteLine("Введите координату Z для третей точки: ");
var two_3_String = Console.ReadLine();
double two_coor_z = int.Parse(two_3_String!);

double result = Math.Sqrt((double) Math.Pow(two_coor_x - one_coor_x,2) + 
                                   Math.Pow(two_coor_y - one_coor_y,2) +
                                   Math.Pow(two_coor_z - one_coor_z,2));

Console.WriteLine(result.ToString("N2"));
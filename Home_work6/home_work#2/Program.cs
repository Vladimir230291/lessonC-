// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1,k1,b2,k2");
bool b1Access = float.TryParse(Console.ReadLine(), out float b1);
bool k1Access = float.TryParse(Console.ReadLine(), out float k1);
bool b2Access = float.TryParse(Console.ReadLine(), out float b2);
bool k2Access = float.TryParse(Console.ReadLine(), out float k2);
if (b1Access
    && k1Access
    && b2Access
    && k2Access)
{
    if (k1 == k2) Console.WriteLine("точек пересечения не существует");

    float x = (b2 - b1) / (k1 - k2);
    float y = (k2 * b1 - k1 * b2) / (k2 - k1);

    Console.WriteLine($"({x}; {y})");

}
else Console.WriteLine("Введите только число");
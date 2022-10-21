// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX (double b2, double k1, double b1, double k2)
{
    double result = (-b2 + b1)/(-k1 + k2);
    return result;
}

double x = FindX(b2, k1, b1, k2);

double FindY (double k2, double x, double b2)
{
    double result1 = k2 * x + b2;
    return result1;
}

double y = FindY(k2, x, b2);

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
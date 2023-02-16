//Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
Console.WriteLine("Введите b1");
double b1 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите k1");
double k1 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите b2");
double b2 = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите k2");
double k2 = double.Parse(Console.ReadLine() ?? "");

double x = (-b2 + b1) / (-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Прямые пересекутся в точке с координатами X: {x}, Y: {y}");
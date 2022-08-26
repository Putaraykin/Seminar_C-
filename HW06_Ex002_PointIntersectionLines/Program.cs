// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double b1 = ReadInt("Введите параметр b1 первой прямой: ");
double k1 = ReadInt("Введите коэффициент k1 первой прямой: ");
double b2 = ReadInt("Введите параметр b2 первой прямой: ");
double k2 = ReadInt("Введите коэффициент k2 первой прямой: ");
double ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
if (k1 != k2 && b1 != b2)
    {
    double PointIntersectionX = (b2-b1)/(k1-k2);
    double PointIntersectionY = (k1*PointIntersectionX+b1);
    Console.Write ($"Координаты пересечения двух заданных прямых равны X: ");
    Console.Write ($"{PointIntersectionX}  Y: {PointIntersectionY}");
    }
        else if (k1 == k2 && b1 == b2)
        Console.WriteLine ("Прямые совпадают");
        else if (k1 == k2)
        Console.WriteLine ("Прямые параллельны");

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int NumberA = ReadInt("Введите сторону A: ");
int NumberB = ReadInt("Введите сторону B: ");
int NumberC = ReadInt("Введите сторону C: ");

int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
if (NumberA < NumberB + NumberC && NumberB < NumberA + NumberC && NumberC < NumberA + NumberC)
         {
          Console.WriteLine ("Треугольник с такими сторонами возможен");
         }
else Console.WriteLine ("Треугольник с такими сторонами не возможен");
﻿int x1 = ReadInt("Введите X точки A: ");
int y1 = ReadInt("Введите Y точки A: ");
int x2 = ReadInt("Введите X точки B: ");
int y2 = ReadInt("Введите Y точки B: ");

int lengthX = x2 - x1;
int lengthY = y2 - y1;
double distance = Math.Sqrt(lengthX * lengthX + lengthY * lengthY);
Console.WriteLine($"A({x1}, {y1}); B({x2}, {y2}) -> {distance}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


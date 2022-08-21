// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)    2, 4 -> 16
int NumberA = ReadInt("Введите первое число: ");
int NumberB = ReadInt("Введите второе число: ");
int Result = 1;

for (int count = 1; count <= NumberB; count++)
{
    Result = Result*NumberA;
}
Console.WriteLine($" {NumberA} в степени {NumberB} -> {Result}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

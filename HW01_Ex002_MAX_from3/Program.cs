//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine ("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите третье число:");
int numberC = Convert.ToInt32(Console.ReadLine());
int maximum = numberA;
if (numberB>maximum) maximum = numberB;
if (numberC>maximum) maximum = numberC; 
{
    Console.WriteLine ($"Максимальное число из трех введенных {maximum}");
}
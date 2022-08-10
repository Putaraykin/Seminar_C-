//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine ("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA<numberB)
{
    Console.Write ($"Первое число {numberA} меньше второго {numberB}");
}
else
if (numberA>numberB)
{
    Console.Write ($"Второе число {numberB} меньше первого {numberA}");
}
if (numberA==numberB)
{
    Console.Write ($"Первое число {numberA} равно второму {numberB}");
}
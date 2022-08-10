//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine ("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA%2 == 0)
{
    Console.Write ($"Введенное число {numberA} является четным");
}
else
{
    Console.Write ($"Введенное число {numberA} является нечетным");
}


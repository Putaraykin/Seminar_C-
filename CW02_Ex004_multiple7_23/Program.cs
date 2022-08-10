// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23. 14 -> нет   46 -> нет  161 -> да
Console.WriteLine ("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA%7 == 0 && numberA%23 == 0)
{
Console.WriteLine ($"Первое число кратно 7 и 23");
}
else
{
Console.WriteLine ($"Первое число не кратно 7 и 23");
}
if (numberB%7 == 0 && numberB%23 == 0)
{
Console.WriteLine ($"Второе число кратно 7 и 23");
}
else
{
Console.WriteLine ($"Второе число не кратно 7 и 23");
}
// Задача Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе. 452 -> 11   82 -> 10
int Sum(int num)
{
    if (num < 10) return num;
    return num % 10 + Sum(num / 10);
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа: {Sum(number)}");
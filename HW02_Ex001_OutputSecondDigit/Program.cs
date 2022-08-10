//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 456 -> 5
int InputNumber = ReadInt("Введите трехзначное число: ");
{
int ReadInt(string message);
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
int FindSecondNumber(int number)
{
int firstDigit = InputNumber / 100;
int lastDigit = InputNumber % 10;
return (InputNumber - (firstDigit * 100 + lastDigit)) / 10;
}
{
    Console.WriteLine (FindSecondNumber(InputNumber));
}
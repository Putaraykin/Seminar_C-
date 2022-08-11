// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
int InputNumber = ReadInt("Введите число: ");
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
if (InputNumber <= 99)
    {
    Console.WriteLine ("Третьей цифры нет");
    }
else if (InputNumber < 999)
    {
    int ThirdDigit = InputNumber % 10;
    Console.WriteLine (ThirdDigit);
    }
        else
        Console.WriteLine (FindThirdDigit(InputNumber));
    int FindThirdDigit(int number)
{   
    while (InputNumber > 999) 
    InputNumber = InputNumber / 10;
    return InputNumber % 10;
}

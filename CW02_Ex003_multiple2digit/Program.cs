// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли первое число кратным второму. 
// Если число 1 не кратно числу 2, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4
int firstNumber = ReadInt("Первое число: ");
int secondNumber = ReadInt("Второе число: ");

int remainderOfDivision = firstNumber % secondNumber;
if (remainderOfDivision == 0)
{
Console.WriteLine("Числа кратны");
}
else
{
Console.WriteLine("Числа не кратны, остаток от деления - " + remainderOfDivision);
}
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}

//моя
//Console.WriteLine ("Введите первое число:");
//int numberA = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine ("Введите второе число:");
//int numberB = Convert.ToInt32(Console.ReadLine());
//int result = numberA%numberB;
//if (result == 0)
//{
//Console.WriteLine ($"Первое число кратно второму");
//}
//else
//{
//Console.WriteLine ($"Первое число {numberA} не кратно второму. Остаток {result}");
//}

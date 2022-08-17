// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. 14212 -> нет 12821 -> да 23432 -> да
int NumberInt;
Console.WriteLine ("Введите пятизначное число:");
String? NumberString = (Console.ReadLine());
NumberInt = Convert.ToInt32(NumberString);
if (NumberInt < 100000 && NumberInt > 9999)
{
        if (NumberString[0] == NumberString[4] || NumberString[1] == NumberString[3]) 
        {
            Console.WriteLine ("Введенное пятизначное число является палиндромом");             
        } 
        else Console.WriteLine ("Введенное пятизначное число не является палиндромом");
}
else Console.WriteLine ("Введенно не пятизначное число");
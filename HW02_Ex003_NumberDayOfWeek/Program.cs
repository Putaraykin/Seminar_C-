// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным. 6 -> да 7 -> да 1 -> нет
int DayNumber = ReadInt("Введите цифру от 1 до 7: ");
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
if (DayNumber <= 5)
    {
    Console.WriteLine ("Нет, не выходной ((");
    }
    else 
    if (DayNumber == 6 || DayNumber == 7)
    {
    Console.WriteLine ("Ура, выходной");
    }
 else 
    Console.WriteLine ("Введена цифра не от 1 до 7");
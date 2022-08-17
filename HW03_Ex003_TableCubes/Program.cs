// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N. 3 -> 1, 8, 27   5 -> 1, 8, 27, 64, 125
int ResultCube;
int Number = ReadInt("Введите число: ");
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
Console.Write ($" {Number} =>");
for (int count = 1; count < Number; count++)
{
ResultCube = count*count*count;
Console.Write ($" {ResultCube} , ");
}
Console.Write ($" {Number*Number*Number}.");

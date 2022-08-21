// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе. 452 -> 11   82 -> 10
int SumDigit=0;
Console.WriteLine ("Введите число:");
String? NumberString = (Console.ReadLine());
for (int i=0; i < NumberString.Length; i++)
    {
      string DigitCount = Convert.ToString(NumberString[i]);
      SumDigit = SumDigit + Convert.ToInt32(DigitCount); 
      }
Console.WriteLine ($"Сумма цифр числа {NumberString} => {SumDigit}");
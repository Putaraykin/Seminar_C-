//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
double randomNumber = new Random().Next(10, 100);
Console.WriteLine(randomNumber);
double firstDigit = randomNumber / 10;
double secondDigit = randomNumber % 10;
if(firstDigit > secondDigit)
{
Console.WriteLine(firstDigit);
}
else
{
Console.WriteLine(secondDigit);
}

// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46

int randomNumber = GetRandomNumber(100, 999);
Console.WriteLine(randomNumber);
Console.WriteLine(DeleteSecondNumber(randomNumber));

int DeleteSecondNumber(int number)
{
int firstDigit = randomNumber / 100;
int lastDigit = randomNumber % 10;
return firstDigit * 10 + lastDigit;
}

int GetRandomNumber(int min, int max)
{
return new Random().Next(min, max + 1);
}

// моя
// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine(randomNumber);
// int number = (randomNumber%100)/10;
// Console.WriteLine (number);
// int digit1 = randomNumber/100;
// int digit3 = randomNumber%10;
// Console.WriteLine (digit1);
// Console.WriteLine (digit3);
// Console.Write (digit1);
// Console.Write (digit3);
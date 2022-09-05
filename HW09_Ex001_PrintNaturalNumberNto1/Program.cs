// Показать натуральные числа от N до 1, N задано
int numberB = 1;
Console.WriteLine("Введите положительное число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ряд натуральных чисел от {numberA} до {numberB}:");
Console.Write(PrintNaturalnumber(numberA, numberB));
int PrintNaturalnumber(int numA, int numB)
{
    if (numB == numA)
    return numA;
    Console.Write($"{PrintNaturalnumber(numA, numB + 1)}, ");
    return numB;
}
// Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberN > 0 && numberM > 0)
{
    Console.WriteLine($"Ряд натуральных чисел от {numberM} до {numberN}:");
    Console.Write(PrintNaturalnumber(numberN, numberM));
    int PrintNaturalnumber(int numN, int numM)
    {
        if (numberN > numberM)
        {
            if (numN == numM)
                return numN;
            Console.Write($"{PrintNaturalnumber(numN - 1, numM)}, ");
            return numN;
        }
        else
        {
            if (numN == numM)
                return numM;
            Console.Write($"{PrintNaturalnumber(numN + 1, numM)}, ");
            return numN;
        }
    }
}
else
{
    Console.WriteLine("Введено не положительное число");
}
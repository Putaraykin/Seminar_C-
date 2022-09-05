// Найти сумму элементов от M до N, N и M заданы
Console.WriteLine("Введите положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
if (numberN > 0 && numberM > 0)
{
    Console.WriteLine($"Сумма элементов (натуральных чисел) в диапазоне от {numberN} до {numberM}:");
    Console.Write(SumNaturalnumber(numberN, numberM));
    int SumNaturalnumber(int numN, int numM)
    {
        if (numberN > numberM)
        {
            if (numN == numM)
                return numM;
            return numN + SumNaturalnumber(numN - 1, numM);
        }
        else
        {
            if (numN == numM)
                return numM;
            return numN + SumNaturalnumber(numN + 1, numM);
        }
    }
}
else
{
    Console.WriteLine("Введено не положительное число");
}

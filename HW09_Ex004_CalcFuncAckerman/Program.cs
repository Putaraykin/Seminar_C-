// Написать программу вычисления функции Аккермана
Console.WriteLine("Введите положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" Функция Аккермана f({numberN}, {numberM}) = {(Ackerman(numberN, numberM))}");
int Ackerman(int numN, int numM)
{
    if (numN == 0)
    {
        return numM + 1;
    }
    if (numN > 0 && numM == 0)
    {
        return Ackerman(numN - 1, 1);
    }
    else
    {
        return Ackerman(numN - 1, Ackerman(numN, numM - 1));
    }
}
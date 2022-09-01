// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(0, 10);
        }
    }
}
FillArray(matrix);
PrintArray(matrix);
void IndexMinSumRow(int[,] matr)
{
    int[] matr1 = new int[matr.GetLength(0)];
    int sumRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRow += matr[i, j];
        }
        matr1[i] = sumRow;
        sumRow = 0;
    }
    Console.WriteLine("Суммы элементов каждой строки соответственно равны:");
    Console.WriteLine(String.Join("  ", matr1));
    int indexMinSumRow = 0;
    int sumRowMin = matr1[0];
    for (int k = 0; k < matr1.Length - 1; k++)
    {
        if (matr1[k] < sumRowMin)
        {
            sumRowMin = matr1[k];
            indexMinSumRow = k;
        }
    }
    Console.WriteLine($" Номер строки с минимальной суммой элементов равен {indexMinSumRow + 1}");
}
Console.WriteLine();
IndexMinSumRow(matrix);
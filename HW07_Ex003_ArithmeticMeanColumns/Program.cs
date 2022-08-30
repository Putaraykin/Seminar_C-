// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.
int m = 3;
int n = 4;
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
void FillRndDoubleArray(int[,] matr)
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
FillRndDoubleArray(matrix);
PrintArray(matrix);
int sumColumn = 0;
double arithmMeanColumn = 0;
double numberRows = (double)matrix.GetLength(0);
Console.WriteLine("Среднее арифметическое каждого столбца:");
void PrintArithmMeanColumn(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sumColumn = sumColumn + matr[i, j];
            if (i == matr.GetLength(0) - 1)
            {
                arithmMeanColumn = sumColumn / numberRows;
                Console.Write($" {arithmMeanColumn};");
                sumColumn = 0;
            }
        }
    }
}
PrintArithmMeanColumn(matrix);
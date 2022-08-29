// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4. 0,5 7 -2 -0,2  1 -3,3 8 -9,9 8 7,8 -7,1 9
Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [m,n];
void PrintArray (double[,] matr)
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
void FillRndDoubleArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        }
    }
}
FillRndDoubleArray(matrix);
PrintArray(matrix);
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
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

void SortMinMaxInRows(int[,] matr)
{
    int[] matr1 = new int[matr.GetLength(1)];
    for (int row = 0; row < matr.GetLength(0); row++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr1[j] = matr[row, j];
        for (int i = 0; i < matr1.Length; i++)
        {
            for (int j = 0; j < matr1.Length - 1; j++)
            {
                if (matr1[j] > matr1[j + 1])
                {
                    int temp = matr1[j];
                    matr1[j] = matr1[j + 1];
                    matr1[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(String.Join("  ", matr1));
    }
}
Console.WriteLine();
SortMinMaxInRows(matrix);


// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
Console.WriteLine("Введите количество строк и столбцов квадратного массива:");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, m];
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
void FillSpiralArray(int[,] matr)
{
    int element = 1;
    int i = 0;
    int j = 0;
    int numberElement = matr.GetLength(0) * matr.GetLength(1);
    while (element <= numberElement)
    {
        matr[i, j] = element;
        element++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}
FillSpiralArray(matrix);
PrintArray(matrix);
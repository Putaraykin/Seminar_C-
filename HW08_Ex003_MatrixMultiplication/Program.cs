// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49
Console.WriteLine("Введите количество строк массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[m, n];
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
            matr[i, j] = rand.Next(0, 5);
        }
    }
}
FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine("1-я матрица:");
PrintArray(matrix1);
Console.WriteLine("2-я матрица:");
PrintArray(matrix2);
Console.WriteLine("Произведение 1-й и 2-й матрицы:");
int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matrixMultiply = new int[m, n];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matrixMultiply[i, j] = matr1[i,j]*matr2[i,j];
        }
    }
    return matrixMultiply;
}
PrintArray(MultiplyMatrix(matrix1, matrix2));
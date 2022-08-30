// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
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
void FillRndArray(int[,] matr)
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
FillRndArray(matrix);
Console.WriteLine("Введите номер строки элемента массива:");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента массива:");
int column = Convert.ToInt32(Console.ReadLine());
PrintArray(matrix);
if (row > m + 1 | column > n + 1 | row <= 0 | column <= 0)
{
    Console.WriteLine("Элемента с такой позицией не существует");
}
else Console.WriteLine($"Элемент с позицией {row},{column} равен {matrix[row - 1, column - 1]}");

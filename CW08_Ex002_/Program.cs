// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.
Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
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
void FillRndArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = rand.Next(1, 10);
        }
    }
}

void frecArray(int[,] matr)
{
    int max = 10;
    int count = 0;
    for (int number = 1; number < max; number++)
        {
            for (int i = 0; i < matr.GetLength(0); i++)
        {         
            for (int j = 0; j < matr.GetLength(1); j++)
        {
                if (matr[i, j] == number)
                {
                    count++;
                }
        }
        }
        Console.WriteLine ($"Количество {number} равно {count}");
        count = 0;
            }
}
FillRndArray(matrix);
PrintArray(matrix);
Console.WriteLine();
frecArray(matrix);
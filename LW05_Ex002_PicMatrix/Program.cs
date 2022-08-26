﻿// Создание двумерного массива
int[,] matrix = new int [20,20];
{

}

void PrintArray (int[,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
            {
            Console.Write ($"{matr[i,j]},");  
            }
            Console.WriteLine();
    }
}
void FillArray (int[,] matr)
    {
        for (int i=0; i < matr.GetLength(0); i++)
        {
            for (int j=0; j < matr.GetLength(1); j++)
                {
                matr[i,j] = new Random().Next(1,2);  
                }
        }
    }
FillArray(matrix);
PrintArray(matrix);

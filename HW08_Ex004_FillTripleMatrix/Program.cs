// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
int m = 2;
int n = 2;
int p = 2;
int size = m * n * p;
int[] arrayRow = new int[size];
FillEqualNumberArrayRow(arrayRow);
void FillEqualNumberArrayRow(int[] array)
{
    int tempNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);
        tempNumber = array[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    tempNumber = array[i];
                }

                tempNumber = array[i];
            }
        }
    }
}
Console.WriteLine("Одномерный массив из неповторяющихся двузначных чисел");
Console.WriteLine(String.Join("  ", arrayRow));

int[,,] matrix = new int[m, n, p];
void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($" {matr[i, j, k]} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}
void FillRndTripleArray(int[,,] matrTriple, int[] matrRow)
{
    for (int l = 0; l < matrRow.Length; l++)
    {
        for (int i = 0; i < matrTriple.GetLength(0); i++)
        {
            for (int j = 0; j < matrTriple.GetLength(1); j++)
            {
                for (int k = 0; k < matrTriple.GetLength(2); k++)
                {
                    matrTriple[i, j, k] = matrRow[l];
                    l++;
                }
            }
        }
    }
}

FillRndTripleArray(matrix, arrayRow);
PrintArray(matrix);
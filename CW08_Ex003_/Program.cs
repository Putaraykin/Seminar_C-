int m = 5;
int n = 5;
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
PrintArray(matrix);
void FindIndexMin(int[,] matr)
{
    int min = matr[0, 0];
    int indexMinRow = 0;
    int indexMinColumn = 0;
    int[,] matrixMin = new int[matr.GetLength(0)-1, matr.GetLength(1)-1];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if  (matr[i, j] < min)
            {
                min = matr[i, j];
                indexMinRow = i;
                indexMinColumn = j;
            }
        }
    }

    int offsetI = 0;
    int offsetJ = 0;
    for (int i = 0; i < matrixMin.GetLength(0); i++)
    {
        if (i == indexMinRow)
        {
            offsetI++;
        }
        for (int j = 0; j < matrixMin.GetLength(1); j++)
        {
            if (j == indexMinColumn)
            {
                offsetJ++;
            }
            matrixMin[i,j] = matr[i + offsetI, j + offsetJ];
        }
        offsetJ = 0;
    }
    PrintArray(matrixMin);
}
FindIndexMin(matrix);

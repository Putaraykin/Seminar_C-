// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int [m,n];
void PrintArray (int[,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
            {
            Console.Write ($"{matr[i,j]}  ");  
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
                matr[i,j] = i+j;  
                }
        }
    }
FillArray(matrix);
PrintArray(matrix);
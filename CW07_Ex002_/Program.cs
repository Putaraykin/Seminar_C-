// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
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
                    matr[i,j] = new Random().Next(1,30);  
                }
        }
    }
FillArray(matrix);

void FillEvenSQRT (int[,] matr)
    {
        for (int i=0; i < matr.GetLength(0); i++)
        {
            for (int j=0; j < matr.GetLength(1); j++)
                {
                    if ((i+1)%2 == 0 && (j+1)%2 == 0)
               matr[i,j] = matr[i,j]*matr[i,j];   
                }
        }
    }
PrintArray(matrix);
Console.WriteLine();
FillEvenSQRT (matrix);
PrintArray(matrix);
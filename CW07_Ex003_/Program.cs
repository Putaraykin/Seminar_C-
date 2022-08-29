// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

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
if (matrix.GetLength(0) < matrix.GetLength(1))
    {
    for (int count=0; count < matrix.GetLength(0); count++)
    {
        sum = sum + matrix[count,count];
    }
    }
    else   for (int count=0; count < matrix.GetLength(1); count++)
    {
        sum = sum + matrix[count,count];
    }
Console.WriteLine($"Сумма {sum}");
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0
int Size = 4;
int Sum = 0;
int[] numbers = new int[Size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
for(int i = 0; i < numbers.Length; i++)
{
    if(i%2 != 0)
    Sum += numbers[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {Sum}");
void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
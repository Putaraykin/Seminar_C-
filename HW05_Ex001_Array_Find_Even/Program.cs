// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int Size = 4;
int count = 0;
int[] numbers = new int[Size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]%2 == 0)
        count++;
}
Console.WriteLine($"Количество чётных чисел в массиве равно {count}");
void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
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
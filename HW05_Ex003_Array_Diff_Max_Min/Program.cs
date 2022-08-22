// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива. [3 7 22 2 78] -> 76
int Size = 4;
double[] numbers = new double[Size];
FillArrayRandomNumbres(numbers);
PrintArray(numbers);
double Min = numbers[0];
double Max = numbers[0];
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]<Min)
    Min = numbers[i];
}
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i]>Max)
    Max = numbers[i];
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {Max - Min}");
void FillArrayRandomNumbres(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20)+0.12;      
    }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
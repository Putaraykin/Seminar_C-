//Задача 32: Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = 10;
int[] numbers = new int[size];
int sumPositive = 0;
int sumNegative = 0;
FillArrayRandomNumbres(numbers);
PrintArray(numbers);

void FillArrayRandomNumbres(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
}
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i]*-1;
    }
PrintArray(numbers);
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

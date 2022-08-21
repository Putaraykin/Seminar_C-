//Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. [6, 7, 19, 345, 3] -> нет [6, 7, 19, 345, 3] -> да
int size = 10;
Console.WriteLine ("Введите число:");
int numberA = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
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
     if(array[i] == numberA)
  {
    true = 1;
    break;
  }
}
if (true == 1)
{
  Console.WriteLine($"{number} число есть!");
}
else Console.WriteLine($"{number} числа нет.");

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел меньше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2   1, -7, 567, 89, 223-> 4
Console.WriteLine("Введите количество вводимых чисел M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[M];
int count = 0;
Console.WriteLine($"Введите последовательно {M} чисел(ла): ");
for(int i = 0; i < M; i++)
{
    int Number = Convert.ToInt32(Console.ReadLine());
    Array[i] = Number;
    if (Array[i] < 0)
    count++;
}
Console.Write(string.Join(" ", Array));
Console.WriteLine($"=> {count}");
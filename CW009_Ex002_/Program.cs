int Multiply(int num, int b)
{
    if (b == 0) return 1;
    else return Multiply(num, b - 1) * num;
}
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} в степени {numberB} равно {Multiply(number, numberB)}");
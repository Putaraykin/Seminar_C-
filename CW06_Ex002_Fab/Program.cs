// 
int Number = ReadInt("Введите число: ");
int fib1 = 0;
int fib2 = 1;
int fib3 = 1;
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
Console.Write ($"{fib1} {fib2} ");
for (int i=2; i < Number; i++)
{
    fib3 = fib1+fib2;
    fib1 = fib2;
    fib2 = fib3;
    Console.Write (fib3+" ");
}


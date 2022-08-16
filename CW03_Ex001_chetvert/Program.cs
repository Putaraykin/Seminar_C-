int Quarter = ReadInt("Введите номер четверти: ");
int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
  if (Quarter == 1)
{
    Console.WriteLine("Диапазон (x > 0 && y > 0)");
}
else if(Quarter == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if(Quarter == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if(Quarter == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else Console.WriteLine ("Четверть определить не удалось");




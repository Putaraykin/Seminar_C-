Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Result = 1;

for (int i = 1; i <= number; i++)
{
    Result = Result*i;
}

Console.WriteLine(Result);


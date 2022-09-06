// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем
Console.WriteLine("Введите количество элементов в последовательности:");
int count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый элемент последовательности:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй элемент последовательности:");
int number2 = Convert.ToInt32(Console.ReadLine());
void SequenceSumPrevious(int num1, int num2, int n)
{
    if (n == 0)
    {
        Console.WriteLine();
        return;
    }
    else
    {
        Console.Write(num1 + " ");
        (num1, num2) = (num2, num1 + num2);
        SequenceSumPrevious(num1, num2, --n);
    }
}
Console.WriteLine("Последовательность, для которой каждый следующий элемент равен сумме двух предыдущих:");
SequenceSumPrevious(number1, number2, count);
//В переменной string есть секретное сообщение, во второй есть пароль. пользователю программы дается 3 попытки ввести пароль и увидеть секретное сообщение
string message = ("Клад в твоем сердце!");
string password = "qwerty";
int index = 0;
int NumberInput = 3;
Console.WriteLine ($"Введите, пожалуйста, пароль (максимум {NumberInput} попытки)");
while (index<NumberInput)
{
    string? input = (Console.ReadLine());
        if (input == password) 
        {
            Console.WriteLine (message);
            break;
        }
        else   
        index++; 
} 
if (index == NumberInput)   
{
Console.WriteLine ("Три попытки ввести пароль использованы. Введенные пароли не верны");
}
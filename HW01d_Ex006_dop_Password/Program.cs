//В переменной string есть секретное сообщение, во второй есть пароль. пользователю программы дается 3 попытки ввести пароль и увидеть секретное сообщение
string message = ("Клад в твоем сердце!!!");
string password = "qwerty";
int i=0;
Console.WriteLine ("Введите, пожалуйста, пароль (максимум 3 попытки):");
while (i<3)
{
    string? input = (Console.ReadLine());
        if (input == password) 
        {
            Console.WriteLine (message);
            break;
        }
        else   
        i++;        
Console.WriteLine ("Три попытки ввести пароль использованы. Введенные пароли не верны");
}
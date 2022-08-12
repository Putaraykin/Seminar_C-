// Программа с бесконечным циклом, при вводе exit программа заканчивается.
// Добавить 4 команды SetName, Help, SetPassword
string LoginName;
string SetPassword;
string InputPassword;
int index=0;
int NumberInput = 3; // Количество попыток ввода пароля.
LoginName = ReadInt("Введите имя учетной записи: ");
SetPassword = ReadInt("Установите пароль учетной записи: ");
InputPassword = ReadInt("Для доступа к учетной записи введите пароль: ");
while (index<NumberInput)
    {
    if (InputPassword == SetPassword)
    Console.WriteLine ("Вход в учетную запись выполнен.");
    else 
    index++;
    }
string ReadInt(string message)
{
Console.Write(message);
return (Console.ReadLine());
}
while (index<1)
   {
    string? Help = (Console.ReadLine());
        if (Help == "Help") 
        {
            Console.WriteLine ("Справка по использованию программы: ");
        }   
    string? Exit = (Console.ReadLine());
        if (Exit == "Exit") 
        {
            Console.WriteLine ("Выполнен выход из программы: ");
            break;
        }     
   }

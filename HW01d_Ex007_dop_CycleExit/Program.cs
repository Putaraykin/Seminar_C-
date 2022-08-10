// Программа с бесконечным циклом, при вводе exit программа заканчивается.
int index=0;
while (index<1)
   {
    string? input = (Console.ReadLine());
        if (input == "exit") 
        {
            Console.WriteLine ("Стоп");
            break;
        }       
   }                 

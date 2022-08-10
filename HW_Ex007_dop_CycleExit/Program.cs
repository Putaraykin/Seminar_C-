// Программа с бесконечным циклом, при вводе exit программа заканчивается.
int i=0;
string input;   
while (i<1)
   {
    input = (Console.ReadLine());
        if (input == "exit") 
        {
            Console.WriteLine ("Стоп");
            break;
        }       
   }                  

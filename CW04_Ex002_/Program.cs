// Console.WriteLine ("Введите число:");
 //int number = Convert.ToInt32(Console.ReadLine());
//int ResultDiv=number;
//int i = 1;
//while ( ResultDiv>10)
//{
//       ResultDiv=ResultDiv/10;
//        i++;
//}
//Console.WriteLine(i);

Console.WriteLine ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int ResultDiv=number;
int Result;
for (int i = 1; ResultDiv>10; i++)
{
        ResultDiv=ResultDiv/10; 
        Result = i;     
}
Console.WriteLine(Result);
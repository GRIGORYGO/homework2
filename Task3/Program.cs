/*Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
int number = GetNumber("Введите день недели:");
int GetNumber(string message)
{
  Console.WriteLine(message);
  int number = Convert.ToInt32(Console.ReadLine());
    if (1<= number && number < 6)
    { 
     Console.WriteLine("нет");
    }
     else if (number == 6 && number == 7)
       {
        Console.WriteLine("Да");
       }
         else Console.WriteLine("Вы ввели не день недели");
return number;
}

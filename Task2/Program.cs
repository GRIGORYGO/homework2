/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SearchDigit(int ThirdDigit)
{
int CalcOne = number / 100;
    if (number < 100)
    {
    Console.WriteLine($"У числа {number} третьей цифры нет");
    }
      if (100 < number && number < 1000)
      {
      ThirdDigit = number % 10;
      return ThirdDigit;
      }
        if (1000 < number && number < 10000) 
         {
          ThirdDigit = number % 10;
          return ThirdDigit;
         }
           if (100000 > number && number > 10000)
            {
             ThirdDigit = CalcOne % 10;
             return ThirdDigit;
            }
}
int digit = SearchDigit(ThirdDigit);
Console.WriteLine($"Третья цифра числа {number}:{digit}(number)");



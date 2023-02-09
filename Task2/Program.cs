/* Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

int SearchDigit(int thirdDigit)
{
 int calcOne = number / 100;
    if (number < 100)
    {
    Console.WriteLine($"У числа {number} третьей цифры нет");
    }
      if (100 < number && number < 1000)
      {
      thirdDigit = number % 10;
      }
        if (1000 < number && number < 10000) 
          {
          thirdDigit = number % 10;
          }
           if (100000 > number && number > 10000)
            {
            thirdDigit = calcOne % 10;
            return thirdDigit;
            }
return thirdDigit;
}
int digit = SearchDigit(number);
Console.WriteLine($"Третья цифра числа {number}:{digit}");



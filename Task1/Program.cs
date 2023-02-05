/*Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int SecondDigit(int number)
{
int DigitOne = number / 10;
int DigitTwo = DigitOne % 10;
return DigitTwo;
}

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра этого числа {SecondDigit(number)}");
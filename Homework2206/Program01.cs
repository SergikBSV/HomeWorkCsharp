/*
7.Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает **последнюю** цифру этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трехзначное число -> ");
int number = Convert.ToInt32(Console.ReadLine());

while (number >= 1000 || number <= 99)
{
    Console.WriteLine("Вы ввели неверно! Введите ТРЕХзначное число -> ");
    number = Convert.ToInt32(Console.ReadLine());

}

int lastNumeral = number % 10;
Console.WriteLine("Последняя цифра в введеном числе: " + lastNumeral);

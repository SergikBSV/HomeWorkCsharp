﻿/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите целое число больше 99 -> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
	while (num > 999)
	{
		num = num / 10;
	}
	Console.WriteLine("Третья цифра в введеном числе: " + num % 10);
}
else
{
	Console.WriteLine("Вы ввели неверно! Третьей цифры нет!");
}


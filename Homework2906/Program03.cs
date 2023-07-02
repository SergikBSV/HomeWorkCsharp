/*
Напишите программу, которая принимает на вход число(N) и выдаёт таблицу
кубов чисел от 1 до N.
3-> 1, 8, 27
5-> 1, 8, 27, 64, 125
*/

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int i = 1;

Console.Write($"{num} ->  ");

while (i <= num)
{

	if (i == num)
	{
		Console.WriteLine($"{i * i * i}.");
	}
	else
	{
		Console.Write($"{i * i * i}, ");
	}
	i++;
}
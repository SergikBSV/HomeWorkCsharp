/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт
сумму цифр в числе.
452-> 11
82-> 10
9012-> 12
*/

Console.Write("Введите число: ");
int number= Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> {SummNamber(number)}");

int SummNamber(int num)
{
	int result = 0;
	while (num > 0)
	{
		result += num % 10;
		num /= 10;
	}
	return result;
}
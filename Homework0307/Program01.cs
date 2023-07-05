/*
Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и 
возводит число A в натуральную степень B.
3, 5-> 243(3⁵)
2, 4-> 16
*/

Console.Write("Введите число A: ");
int numberA= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{numberA}, {numberB} -> {Degree(numberA, numberB)}");

int Degree(int bas, int deg)
{
	int i = 1;
	int result = 1;

	while (i <= deg)
	{
		result *= bas;
		i++;
	}
	return result;
}
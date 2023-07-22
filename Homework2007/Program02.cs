/*
Задача 66: Задайте значения M и N.Напишите программу, которая найдёт сумму натуральных элементов
в промежутке от M до N.
M = 1; N = 15-> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M: ");
int startM = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int stopN = int.Parse(Console.ReadLine());

Console.Write($"M = {startM}; N = {stopN} -> ");
Console.WriteLine(Summ(startM, stopN));

int Summ(int m, int n)
{
	int s = m;
	if (m == n) return s;
	return( s + Summ(m+1, n));
}
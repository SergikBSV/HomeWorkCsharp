/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)
*/


Console.Write("Введите коэффициент k1 для уравнения первой прямой -> ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1 для уравнения первой прямой -> ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2 для уравнения второй прямой -> ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 для уравнения второй прямой -> ");
int b2 = Convert.ToInt32(Console.ReadLine());

CoordinatesPoint(k1,b1,k2,b2);

void CoordinatesPoint (double yk1, double yb1, double yk2, double yb2)
{
	if (yk1 != yk2)
	{
		double x = (yb2 - yb1) / (yk1 - yk2);
		double y = (yk1 * yb2 - yk2 * yb1) / (yk1 - yk2);
		Console.WriteLine($"K1 = {yk1}, B1 = {yb1}, K2 = {yk2}, B2 = {yb2} -> ({Math.Round(x, 2)};{Math.Round(y, 2)})");
	}
	else
		Console.WriteLine("Прямые паралельны и не пересекаются");
}
/*
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.
A(3, 6, 8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53
*/

Console.WriteLine("Введите координаты первой точки");
Console.Write("координата X1 -> ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Y1 -> ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Z1 -> ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("координата X2 -> ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Y2 -> ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("координата Z2 -> ");
double z2 = Convert.ToDouble(Console.ReadLine());

double length = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 2,
	MidpointRounding.ToEven);

Console.WriteLine($"Растояние между первой точкой {x1},{y1},{z1} и второй точкой {x2},{y2},{z2} равно {length}");

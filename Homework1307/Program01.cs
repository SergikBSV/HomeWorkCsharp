/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 - 2 - 0,2
1 - 3,3 8 - 9,9
8 7,8 - 7,1 9
*/

Console.Write("Введите размерность массива. Число строк -> ");
int dimensionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива. Число столбцов -> ");
int dimensionN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число знаков после запятой -> ");
int characters = Convert.ToInt32(Console.ReadLine());

PrintArray(ArrayAutoDouble(dimensionM, dimensionN, characters));

//Формирует массив с вещественными числами (-10; 10) с заданной точностью
double[,] ArrayAutoDouble(int m, int n, int dchar)
{
	double[,] result = new double[m,n];
	Random rnd = new Random();
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			result[i,j] = Math.Round(rnd.NextDouble() * 20 - 10, dchar);
	return result;
}

void PrintArray(double[,] array)
{
	Console.WriteLine("[");
	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < array.GetLength(1) - 1; j++)
			Console.Write($"{array[i, j]} ");
		Console.WriteLine($"{array[i, array.GetLength(1) - 1]}]");
	}
	Console.WriteLine("]");
}
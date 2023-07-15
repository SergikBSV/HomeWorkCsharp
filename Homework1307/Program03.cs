/*
Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Console.Write("Введите размерность массива. Число строк -> ");
int dimensionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива. Число столбцов -> ");
int dimensionN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива -> ");
int dimensionMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива -> ");
int dimensionMax = Convert.ToInt32(Console.ReadLine()) + 1;

int[,] arrayResult = NewArrayAuto(dimensionM, dimensionN, dimensionMin, dimensionMax);
PrintArray(arrayResult);
Console.WriteLine($"Среднее арифметическое каждого столбца: " +
	$"[{String.Join("; ", MeanColumn(arrayResult))}]");


double[] MeanColumn(int[,] array)
{
	double[] result = new double[array.GetLength(1)];               
	for (int n = 0; n < array.GetLength(1); n++)
	{
		double summ = 0; 
		for (int m = 0; m < array.GetLength(0); m++)
			summ += array[m, n];
		result[n] = summ / array.GetLength(0);
	}
	return result;
}


int[,] NewArrayAuto(int m, int n, int minValue, int MaxValue)
{
	int[,] result = new int[m, n];
	Random rnd = new Random();
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			result[i, j] = rnd.Next(minValue, MaxValue);
	return result;
}

void PrintArray(int[,] array)
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
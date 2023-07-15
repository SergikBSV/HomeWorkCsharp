/*
Задача 50.Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17->такого числа в массиве нет
*/

Console.Write("Введите размерность массива. Число строк -> ");
int dimensionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность массива. Число столбцов -> ");
int dimensionN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение элемента массива -> ");
int dimensionMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение элемента массива -> ");
int dimensionMax = Convert.ToInt32(Console.ReadLine()) + 1;

Console.WriteLine("Массив создан. Для поиска значения элемента в массиве, введите");
Console.Write("строку m -> ");
int searchM = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("столбец n -> ");
int searchN = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] arrayResult = NewArrayAuto(dimensionM, dimensionN, dimensionMin, dimensionMax);
Console.WriteLine(); 
PrintArray(arrayResult);
Console.WriteLine();
SearchElementInArray(arrayResult, searchM, searchN);


void SearchElementInArray(int[,] array, int m, int n)
{
	if (m <= array.GetLength(0) && n <= array.GetLength(1))
		Console.WriteLine($"Значение элемента массива [{m + 1},{n + 1}] равно {array[m, n]}");
	else Console.WriteLine($"Элемента [{m + 1},{n + 1}] в заданном массиве нет");
}

int[,] NewArrayAuto(int m, int n, int minValue, int MaxValue)
{
	int[,] result = new int[m,n];
	Random rnd = new Random();
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			result[i,j] = rnd.Next(minValue, MaxValue);
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

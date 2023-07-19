/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
Console.WriteLine(); 
Console.WriteLine("Исходный массив:");
PrintArrayZero(arrayResult, dimensionMax);
SortToMim(arrayResult);
Console.WriteLine("Массив после сортировки строк по убыванию:");
PrintArrayZero(arrayResult, dimensionMax);

void SortToMim(int[,] array)
{
	int tmp;
	for (int i=0; i< array.GetLength(0); i++)
		for (int k = 0; k < array.GetLength(1); k++)
			for (int j = 0; j < array.GetLength(1) - 1; j++)
				if (array[i, j + 1] > array[i, j])
				{
					tmp = array[i, j];
					array[i, j] = array[i, j + 1];
					array[i, j + 1] = tmp;
				}
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

//Вывод массива с красивой симметрией - добавление "0" слева от цифры до нужной разрядности
void PrintArrayZero(int[,] array, int s)
{
	string zero = "0";
	while (s / 10 > 1)
	{
		zero += "0";
		s /= 10;
	}
	Console.WriteLine("[");
	for (int i = 0; i < array.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < array.GetLength(1) - 1; j++)
			Console.Write($"{array[i, j].ToString(zero)} ");
		Console.WriteLine($"{array[i, array.GetLength(1) - 1].ToString(zero)}]");
	}
	Console.WriteLine("]");
}
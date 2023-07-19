/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
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
Console.WriteLine();
FindLine(arrayResult);

void FindLine(int[,] array)
{
	int result = 0;
	int sum = 0;
	int tmpSum;
	for (int i = 0; i < array.GetLength(0); i++)
	{
		tmpSum = 0;
		for (int j = 0; j < array.GetLength(1); j++)
			tmpSum += array[i, j];
		if (i == 0)
			sum = tmpSum;
		if (tmpSum < sum)
		{
			sum = tmpSum;
			result = i;
		}
	}
	Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result + 1}");
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
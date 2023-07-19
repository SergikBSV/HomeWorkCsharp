
/*
Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

BeginMatrix();

void BeginMatrix()
{
	int [,] arraySize = MatrixSize(); //получили размерность матриц

	if (arraySize[0,1] == arraySize[1,0])
	{
		int[] arrayDimension = EnterDimension(); //получаем минимальное и максимальное значение элементов
		int[,] arrayMatrix1 = NewMatrixAuto(arraySize[0, 0], arraySize[0, 1], arrayDimension[0], arrayDimension[1]);
		int[,] arrayMatrix2 = NewMatrixAuto(arraySize[1, 0], arraySize[1, 1], arrayDimension[0], arrayDimension[1]);
		Console.WriteLine("Первая матрица:");
		PrintArray(arrayMatrix1);
		Console.WriteLine("Вторая матрица:");
		PrintArray(arrayMatrix2);
		int[,] arrayMulti = MultiplicationMatrix(arrayMatrix1, arrayMatrix2);
		Console.WriteLine("Произведение матриц");
		PrintArray(arrayMulti);
	}
	else
		Console.WriteLine("Перемножить нельзя!" +
		"Количество столбцов первой матрицы не равно количеству строк второй матрицы");
}

int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)//Перемножение матриц
{
	int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
	for (int i = 0; i < result.GetLength(0); i++)
		for (int j = 0; j < result.GetLength(1); j++)
		{
			result[i, j] = 0;
			for (int k = 0; k < result.GetLength(0); k++)
				result[i, j] += matrix1[i, k] * matrix2[k, j];
		}
return result;
}

int[,] MatrixSize()
{
	int[,] result = new int[2, 2];
	for (int i = 0; i < 2; i++)
	{
		Console.Write($"Введите размерность матрицы №{i + 1}. Число строк -> ");
		result[i, 0] = Convert.ToInt32(Console.ReadLine());
		Console.Write($"Введите размерность матрицы №{i + 1}. Число столбцов -> ");
		result[i, 1] = Convert.ToInt32(Console.ReadLine());

	}
	return result;
}

int[] EnterDimension()
{
	int[] result = new int[2];
	Console.Write("Введите минимальное значение элемента матрицы -> ");
	result[0] = Convert.ToInt32(Console.ReadLine());
	Console.Write("Введите максимальное значение элемента матрицы -> ");
	result[1] = Convert.ToInt32(Console.ReadLine());
	return result;
}

int[,] NewMatrixAuto(int m, int n, int minValue, int MaxValue)
{
	int[,] result = new int[m, n];
	Random rnd = new Random();
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			result[i, j] = rnd.Next(minValue, MaxValue + 1);
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



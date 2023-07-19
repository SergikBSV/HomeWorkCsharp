/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.Напишите программу,
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0, 0, 0) 25(0, 1, 0)
34(1, 0, 0) 41(1, 1, 0)
27(0, 0, 1) 90(0, 1, 1)
26(1, 0, 1) 55(1, 1, 1)
*/

Console.Write("Введите размерность [m,,] массива. Число строк -> ");
int dimensionM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность [,n,] массива. Число столбцов -> ");
int dimensionN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность [,,l] массива. Число массивов -> ");
int dimensionL = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Массив размером {dimensionM}x{dimensionN}x{dimensionL}");
Console.WriteLine();
PrintArray(NewArrayAuto(dimensionM, dimensionN, dimensionL));

int[,,] NewArrayAuto(int m, int n, int l)
{
	int[] arrayTmp = new int[m * n * l];
	int[,,] result = new int[m, n, l];
	Random rnd = new Random();
	arrayTmp[0] = 0;
	int tmp = 0;
	for (int i = 0; i < m; i++)
		for (int j = 0; j < n; j++)
			for (int k = 0; k < l; k++)
			{
				tmp = rnd.Next(10, 100);
				for (int r = 0; r <= n+j+k; r++)
				{
					if (arrayTmp[r] == tmp)
						tmp = rnd.Next(10, 100);
				}
				arrayTmp[i+j+k] = tmp;
				result[i, j, k] = tmp;
			}
	return result;
}

void PrintArray(int[,,] array)
{
	for (int i = 0; i < array.GetLength(2); i++)
	{
		for (int j = 0; j < array.GetLength(0); j++)
		{
			for (int k = 0; k < array.GetLength(1); k++)
				Console.Write($"{array[j, k, i]}({j},{k},{i}) ");
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}

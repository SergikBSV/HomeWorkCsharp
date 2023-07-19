/*
Задача 62.Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.Write("Введите размерность двумерного массива N на N -> ");
int sizeN = Convert.ToInt32(Console.ReadLine());

int[,] arrayNew = SpiralArray(sizeN);
PrintArrayZero(arrayNew, sizeN);

int[,] SpiralArray(int n)
{
	int[,] result = new int[n, n];
	int value = 1; //Заполняемые данные от 1
	int counter = n; //Счетчик колличества строк (столбцов)
	int ind = 0; //Промежуточная переменная для расчета индекса

	while (Math.Ceiling(Convert.ToDouble(counter / 2)) > 0) //так как за цикл заполняется 2 столбца и 2 строки, то обходы кратные 2-м, если N нечетное, то округляем деление на 2 вверх
	{
		for (int i = 0; i < 4; i++) //4 прохода: Л-П, В-Н, П-Л и Н-В
		{
			for (int j = 0; j < counter; j++)
			{                           
				if (i == 0 && j < counter - ind)
					result[i + ind, j + ind] = value++;
				if (j != 0)
				{
					if (i == 1 && j < counter - ind)
						result[j + ind, counter - 1] = value++;
					if (i == 2 && j < counter - ind)
						result[counter - 1, counter - (j + 1)] = value++;
					if (i == 3 && j < counter - (ind + 1))
						result[counter - (j + 1), ind] = value++;
				}
			}
		}
		ind++;
		counter--;
	}
	return result;
}

//Вывод массива с красивой симметрией - добавление "0" слева от цифры до нужной разрядности
void PrintArrayZero(int[,] array, int n)
{
	string zero = "0";
	int s = n * n;
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
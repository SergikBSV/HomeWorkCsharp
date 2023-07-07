/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
*/

Console.Write("Введите размерность массива -> ");
int dimension = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива -> ");
int dimensionMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива -> ");
int dimensionMax = Convert.ToInt32(Console.ReadLine()) + 1;

PrintArray(NewArrayAuto(dimension));
Console.WriteLine(" -> " + Summer(NewArrayAuto(dimension)));

int[] NewArrayAuto(int sel)
{
	int[] array = new int[sel];
	Random rnd = new Random();
	for (int i = 0; i < sel; i++)
	{
		array[i] = rnd.Next(dimensionMin, dimensionMax);
	}
	return array;
}

int Summer(int[] array)
{
	int sum = 0;
	for (int i = 1; i < array.Length; i += 2)
	{
		sum += array[i];
	}
	return sum;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	Console.Write(String.Join(", ", array));
	Console.Write("]");
}
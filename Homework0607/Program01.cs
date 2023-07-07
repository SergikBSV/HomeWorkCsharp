/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Write("Введите размерность массива -> ");
int dimension = Convert.ToInt32(Console.ReadLine());

PrintArray(NewArrayAuto(dimension));
Console.WriteLine(" -> " + Counter(NewArrayAuto(dimension)));

int[] NewArrayAuto(int sel)
{
	int[] array = new int[sel];
	Random rnd = new Random();
	for (int i = 0; i < sel; i++)
	{
		array[i] = rnd.Next(100,1000);
	}
	return array;
}

int Counter(int[] array)
{
	int number = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0) {
			number++;
		}
	}
	return number;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	Console.Write(String.Join(", ", array));
	Console.Write("]");
}
/*
Задача 45. Напишите программу, которая будет создавать копию заданного массива
с помощью поэлементного копирования.
*/

Console.Write("Введите размерность массива -> ");
int dimension = Convert.ToInt32(Console.ReadLine());

PrintArray(NevArrayAuto(dimension));
Console.Write(" -> ");
PrintArray(CopyArray(NevArrayAuto(dimension)));
Console.WriteLine();

int[] NevArrayAuto(int value)
{
	int[] result = new int[value];
	Random rnd = new Random();
	for (int i = 0; i < value; i++)
		result[i] = rnd.Next(100);
	return result;
}

int[] CopyArray(int[] array)
{
	int[] result = new int[array.Length];
	for (int i = 0;i < array.Length;i++)
		result[i] = array[i];
	return result;
}

void PrintArray(int[] array)
{
	Console.Write("[");
	Console.Write(String.Join(", ", array));
	Console.Write("]");
}
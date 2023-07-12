/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
больше 0 ввёл пользователь.
0, 7, 8, -2, -2-> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите числа через пробел -> ");
string[] strNumbers = Console.ReadLine().Split(' ');

PrintArrayString(strNumbers);
Console.WriteLine(" -> " + CounterPositive(ConvertStringToInt(strNumbers)));


int[] ConvertStringToInt(string[] array)
{
	int[] result = new int[array.Length];
	for (int i = 0; i < array.Length; i++)
		result[i] = Convert.ToInt32(array[i]);
	return result;
}

int CounterPositive(int[] array)
{
	int result = 0;
	for (int i = 0;i < array.Length;i++)
		if (array[i] > 0)
			result++;
	return result;
}

void PrintArrayString(string[] array)
{
	Console.Write("[" + String.Join(", ", array) + "]");
}
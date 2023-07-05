/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/


Console.Write("Введите размерность массива -> ");
int dimension = Convert.ToInt32(Console.ReadLine());

Console.Write("Вы хотите задать элементы массива в ручную? Введите y или n -> ");
string select = Console.ReadLine();

switch (select)
{
	case "n":
		Console.WriteLine("Массив задается автоматически в диапозоне значений от 0 до 99. Получите результат:");
		PrintArray(NevArrayAuto(dimension));
		break;
	case "y":
		Console.WriteLine("Вы выбрали ручной ввод массива. Приступаем:");
		PrintArray(NevArrayManual(dimension));
		break;
	default:
		Console.WriteLine("Вы сделали неврный выбор. Запустите программу заново и сделайте верный выбор y или n");
		break;

}

int [] NevArrayAuto(int sel)
{
	int[] array = new int[sel];
	Random rnd = new Random();
	for (int i = 0; i < sel; i++)
	{
		array[i] = rnd.Next(100);
	}
	return array;
}
// Конструкция array[i] = new Random().Next(2); создает последовательность из одинаковых чисел

int[] NevArrayManual(int sel)
{
	int[] array = new int[sel];
	for (int i = 0; i < sel; i++)
	{
		Console.Write($"Введите {i + 1}-й элемент массива: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

void PrintArray(int[] array)
{
	Console.Write(String.Join(", ", array));
	Console.Write(" -> [");
	Console.Write(String.Join(", ", array));
	Console.WriteLine("]");
}
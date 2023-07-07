/*
Задача 38: Задайте массив вещественных чисел.  
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

Console.Write("Введите размерность массива -> ");
int dimension = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число знаков после запятой -> ");
int dcharacters = Convert.ToInt32(Console.ReadLine());

PrintArrayDouble(NewArrayAutoDouble(dimension, dcharacters));
double minElement = MinMaxDifference(NewArrayAutoDouble(dimension, dcharacters))[0];
double maxElement = MinMaxDifference(NewArrayAutoDouble(dimension, dcharacters))[1];
double difElement = MinMaxDifference(NewArrayAutoDouble(dimension, dcharacters))[2];
Console.WriteLine($" => {maxElement} - {minElement} = {difElement}");

/*
В методе сформируется массив в диапозоне от 0 до 100.
Для диапозона до 10 необходимо будет rnd.NextDouble() умножить на 10.
Для диапозона до 1000 - умножить на 1000 и так далее.
По умолчанию будет формироваться диапозон от 0 до 1.
*/
double[] NewArrayAutoDouble(int sel, int dchar)
{
	double[] array = new double[sel];
	Random rnd = new Random();
	for (int i = 0; i < sel; i++)
	{
		array[i] = Math.Round(100 * rnd.NextDouble(), dchar);
	}
	return array;
}

double[] MinMaxDifference(double[] array)
{
	double min = array[0];
	double max = array[0];
	for (int i = 1; i < array.Length; i++)
	{ 
	if (array[i] < min)
		{
			min = array[i];
		}
	if (array[i] > max)
		{
			max = array[i];
		}                           
	}
	double[] resault = new double[3];
	resault[0] = min;
	resault[1] = max;
	resault[2] = max - min;
	return resault;
}

void PrintArrayDouble(double[] array)
{
	Console.Write("[");
	Console.Write(String.Join(", ", array));
	Console.Write("]");
}
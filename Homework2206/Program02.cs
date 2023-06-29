/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите 1-е число -> ");
int number = Convert.ToInt32(Console.ReadLine());
int maxNumber = number;
int i = 2;

while (i <= 3)
{

    Console.Write($"Введите {i}-е число -> ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number > maxNumber)
    { 
        maxNumber = number;
    }
    i++;

}

Console.WriteLine("Максимальное чило равно: " + maxNumber);

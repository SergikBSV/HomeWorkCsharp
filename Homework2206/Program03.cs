/*
Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число, до которого Вы хотите получить четные числа -> ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 4;

if (number <= 1 )
{
    Console.WriteLine("Вы ввели число меньше 2, поэтому задача не имеет решения");
}
else
{
    Console.Write("2");
    while (i <= number)
    {
        Console.Write($", {i}");
        i = i + 2;
    }
}
Console.WriteLine();

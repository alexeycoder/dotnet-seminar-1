﻿// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 5; b = 25->да
// a = 2 b = 10->нет
// a = 9; b = -3->нет
// 10 мин
// a = -3 b = 9 -> да

Console.WriteLine("Проверка является ли первое введёное число квадратом второго.");
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{
	Console.WriteLine("Да.");
}
else
{
	Console.WriteLine("Нет.");
}

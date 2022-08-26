// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите целое положительное число: ");
double number = Math.Truncate(Convert.ToDouble(Console.ReadLine()));
if (number <= 0)
{
	Console.WriteLine("Ошибка: Некорректный ввод!");
	return;
}

Console.WriteLine($"Произведение чисел от 1 до {number} = {Fact(number)}");

double Fact(double num)
{
	double fact = 1;
	for (double i = 1; i <= num; ++i)
	{
		fact *= i;
	}
	return fact;
}

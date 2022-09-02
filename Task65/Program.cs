// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите целое положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNaturalisV2(m, n);

Console.WriteLine();

static void PrintNaturalis(int m, int n)
{
	Console.Write($"{m} ");

	if (m > n)
		PrintNaturalis(m - 1, n);
	else if (m < n)
		PrintNaturalis(m + 1, n);
}

static void PrintNaturalisV2(int m, int n)
{
	if (m == n)
	{
		Console.Write($"{m}");
		return;
	}
	Console.Write($"{m}, ");

	if (m > n)
		PrintNaturalisV2(m - 1, n);
	else if (m < n)
		PrintNaturalisV2(m + 1, n);
}

// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintFibonacciSequence(n);

// Methods

void PrintFibonacciSequence(int n)
{
	int prevPrev = 0;
	int prev = 1;

	Console.Write($"{prevPrev} {prev} ");

	for (int i = 3; i <= n; ++i)
	{
		int fibo = prev + prevPrev;
		Console.Write(fibo + " ");

		prevPrev = prev;
		prev = fibo;
	}

	Console.WriteLine();
}

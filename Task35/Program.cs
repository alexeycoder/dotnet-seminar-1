// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

var tmp = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGray;

int[] arr = CreateArrayRndInt(123, 0, 123);

Console.Clear();
PrintArray(arr);

int cnt = CountInRange(arr, 10, 99);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($" -> {cnt}");

Console.ForegroundColor = tmp;

// Methods

int[] CreateArrayRndInt(int size, int min, int max)
{
	if (size == 0)
		return new int[] { };

	Random rnd = new Random();
	int[] array = new int[size];
	for (int i = 0; i < size; ++i)
	{
		array[i] = rnd.Next(min, max + 1);
	}

	return array;
}

int CountInRange(int[] array, int min, int max)
{
	if (array == null || array.Length <= 0)
	{
		return 0;
	}

	int count = 0;
	for (int i = 0; i < array.Length; ++i)
	{
		if (array[i] >= min && array[i] <= max)
			++count;
	}

	return count;
}

void PrintArray(int[] array)
{
	if (array == null || array.Length <= 0)
	{
		Console.WriteLine("Массив пуст.");
		return;
	}

	Console.Write("[");
	for (int i = 0; i < array.Length - 1; i++)
	{
		Console.Write($"{array[i]}, ");
	}
	Console.Write($"{array[array.Length - 1]}]");
}

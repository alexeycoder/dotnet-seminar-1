// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int[] result = CreateArrayRndInt(12, -9, 9);
PrintArray(result);
int[] negPosSums = GetSumPositiveNegative(result);
Console.WriteLine($"Сумма отрицательных элементов = {negPosSums[0]}\nСумма положительных элементов = {negPosSums[1]}");

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

int[] GetSumPositiveNegative(int[] array)
{
	if (array == null || array.Length <= 0)
		return new int[] { 0, 0 };

	int sumPositive = 0;
	int sumNegative = 0;
	for (int i = 0; i < array.Length; ++i)
	{
		if (array[i] < 0)
			sumNegative += array[i];
		else
			sumPositive += array[i];
	}

	return new int[] { sumNegative, sumPositive };
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
	Console.WriteLine($"{array[array.Length - 1]}]");
}

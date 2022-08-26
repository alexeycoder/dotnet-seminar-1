// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

Console.Write("Введите число элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
	Console.WriteLine("Ошибка: Число элементов должно быть натуральным числом!");
	return;
}
int[] arr = CreateArrayRndInt(qty, 0, 9);

PrintArray(arr);
int[] multsArr = GetMults(arr);
Console.Write($" -> ");

PrintArray(multsArr);

Console.WriteLine();

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

int[] GetMults(int[] array)
{
	int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;

	int[] result = new int[size];

	int firstIndex = 0;
	int lastIndex = array.Length - 1;
	while (lastIndex > firstIndex)
	{
		result[firstIndex] = array[firstIndex] * array[lastIndex];
		++firstIndex;
		--lastIndex;
	}
	if (lastIndex == firstIndex)
	{
		result[size - 1] = array[lastIndex];
	}

	return result;
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

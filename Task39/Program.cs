// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

Console.Write("Введите число элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
	Console.WriteLine("Ошибка: Число элементов должно быть натуральным числом!");
	return;
}
int[] arr = CreateArrayRndInt(qty, 0, 9);

PrintArray(arr);

ReverseArray(arr);

Console.Write(" -> ");
PrintArray(arr);

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

void ReverseArray(int[] array)
{
	for (int firstIndex = 0, lastIndex = array.Length - 1; lastIndex > firstIndex; ++firstIndex, --lastIndex)
	{
		var tmp = array[firstIndex];
		array[firstIndex] = array[lastIndex];
		array[lastIndex] = tmp;
	}
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

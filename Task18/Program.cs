// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число элементов массива: ");
int qty = Convert.ToInt32(Console.ReadLine());
if (qty <= 0)
{
	Console.WriteLine("Ошибка: Число элементов должно быть натуральным числом!");
	return;
}
int[] result = GetArray(qty);
PrintArray(result);

// Methods

int[] GetArray(int size)
{
	if (size == 0)
		return new int[] { };

	Random rnd = new Random();
	int[] array = new int[size];
	for (int i = 0; i < size; ++i)
	{
		array[i] = rnd.Next(0, 2);
	}
	return array;
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
		Console.Write($"{array[i]},");
	}
	Console.WriteLine($"{array[array.Length - 1]}]");
}

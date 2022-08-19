// Задача 33: Задайте массив.Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(12, 0, 345);
arr[1] = 12; // <-- для теста
PrintArray(arr);

string answer = FindNumber(arr, number) ? "Да" : "Нет";
Console.WriteLine($" -> {answer}");

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

bool FindNumber(int[] array, int num)
{
	if (array == null || array.Length <= 0)
	{
		return false;
	}

	for (int i = 0; i < array.Length; ++i)
	{
		if (array[i] == num)
			return true;
	}

	return false;
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

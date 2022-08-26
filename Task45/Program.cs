// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[] origArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] newArray = CloneArray(origArray);

newArray[0] = 11; newArray[2] = 33;

Console.Write("Original: ");
PrintArray(origArray, "G");
Console.WriteLine();
Console.Write("Clone modified: ");
PrintArray(newArray, "G");
Console.WriteLine();

// Methods

static T[] CloneArray<T>(T[] array)
{
	T[] clone = new T[array.Length];

	for (int i = 0; i < array.Length; ++i)
	{
		clone[i] = array[i];
	}

	return clone;
}

static void PrintArray<T>(T[] array, string format) where T : struct, IFormattable
{
	int lastIndex = array.Length - 1;

	if (array == null || lastIndex < 0)
	{
		Console.WriteLine("Массив пуст.");
		return;
	}

	Console.Write("[");
	for (int i = 0; i < lastIndex; i++)
	{
		T item = array[i];
		Console.Write(item.ToString(format, null));
		Console.Write(", ");
	}

	T lastItem = array[lastIndex];
	Console.Write(lastItem.ToString(format, null));
	Console.Write("]");
}

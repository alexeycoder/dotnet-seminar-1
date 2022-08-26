var arr = new int[] { 10, 5, 14, -8, 57, -26, 44, 15 };
Console.WriteLine(string.Join('\t', arr));
SelectionSort(arr);
Console.WriteLine(string.Join('\t', arr));

void SelectionSort(int[] array)
{
	for (int i = 0; i < array.Length - 1; ++i)
	{
		int minPosition = i;

		for (int j = i + 1; j < array.Length; ++j)
		{
			if (array[j] < array[minPosition])
				minPosition = j;
		}

		if (minPosition != i)
		{
			Swap(array, i, minPosition);
		}
	}
}

void Swap(int[] array, int indexA, int indexB)
{
	int temp = array[indexA];
	array[indexA] = array[indexB];
	array[indexB] = temp;
}

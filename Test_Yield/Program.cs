Numbers numbers = new Numbers();
foreach (int n in numbers)
{
	Console.WriteLine(n);
}

Console.WriteLine();


class Numbers
{
	public IEnumerator<int> GetEnumerator()
	{
		for (int i = 0; i < 6; i++)
		{
			yield return i * i;
		}

		yield return 1;
		yield return 11;
		yield return 35;
		yield return 84;

	}
}



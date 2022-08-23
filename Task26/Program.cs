// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите неотрицательное десятичное число: ");
int decNum = Convert.ToInt32(Console.ReadLine());

long binNum = GetPseudoBinary(decNum);

Console.WriteLine($"{decNum} -> {binNum}");

Console.Write("Recursive print: ");
PrintDecToBin(decNum);
Console.WriteLine();

// Methods

static long GetPseudoBinary(long decimalNumber)
{
	long result = 0;
	int i = 1;

	while (decimalNumber > 0)
	{
		result += decimalNumber % 2 * i;
		decimalNumber /= 2;
		i *= 10;
	}

	return result;
}

void PrintDecToBin(int num)
{
	if (num == 0)
		return;

	PrintDecToBin(num / 2);
	Console.Write(num % 2);
}
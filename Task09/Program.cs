// 9.Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);

Console.WriteLine($"Случайное двузначное число -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
// 	Console.WriteLine($"Наибольшая цифра из числа {number} -> {firstDigit}");
// else if (secondDigit > firstDigit)
// 	Console.WriteLine($"Наибольшая цифра из числа {number} -> {secondDigit}");
// else
// 	Console.WriteLine($"Обе цифры из числа {number} равны между собой -> {firstDigit}");

int result = MaxDigit(number);

if (result < 0)
	Console.WriteLine($"Обе цифры двузнасного числа {number} равны между собой -> {-result} и {-result}");
else
	Console.WriteLine($"Наибольшая цифра двузначного числа {number} -> {result}");

//Console.WriteLine(GetNthDigit(256, 2, 10));

int MaxDigit(int num)
{
	int firstDigit = num / 10;
	int secondDigit = num % 10;
	return firstDigit > secondDigit ? firstDigit : (secondDigit > firstDigit ? secondDigit : -firstDigit);
}

// static int GetNthDigit(int num, int n, int numberBase)
// {
// 	// Skip (n-1) digits in base
// 	for (int i = 1; i < n; i++)
// 		num = num / numberBase;

// 	// Nth digit from right in base
// 	return num % numberBase;
// }

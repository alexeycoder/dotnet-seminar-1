// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetNumberOfDigits(number);
Console.WriteLine($"Количество цифр в числе {number} = {result}");

int GetNumberOfDigits(int num)
{
	if (num < 0)
		num = -num;

	if (num < 10)
		return 1;

	int count = 0;
	while (num != 0)
	{
		++count;
		num /= 10;
	}
	return count;
}

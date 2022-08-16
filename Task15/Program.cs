// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0)
{
	Console.WriteLine("Ошибка: Некорректный ввод!");
	return;
}

Console.WriteLine($"Сумма чисел от 1 до {number} = {Sum(number)}");

int Sum(int end)
{
	int sum = 0;
	for (int i = 1; i <= end; ++i)
	{
		sum += i;
	}
	return sum;
}

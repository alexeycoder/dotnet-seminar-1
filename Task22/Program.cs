// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1)
{
	Console.WriteLine("Ошибка: Требуется целое положительное число!");
	return;
}
PrintSquares(n);

void PrintSquares(int a)
{
	for (int i = 1; i <= a; ++i)
		Console.WriteLine($"{i,3}\t{i * i,-5}");
}

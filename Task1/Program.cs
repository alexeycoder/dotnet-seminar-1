// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите gt число: ");
string? str = Console.ReadLine();

if (string.IsNullOrWhiteSpace(str))
{
	Console.WriteLine("Ошибка: некорректный ввод!");
	return;
}

int num = Convert.ToInt32(str);

int square = num * num;

Console.WriteLine($"Квадрат числа {num} = {square}");

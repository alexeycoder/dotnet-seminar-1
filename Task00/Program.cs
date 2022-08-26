// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число: ");
string? str = Console.ReadLine();

if (string.IsNullOrWhiteSpace(str))
{
	Console.WriteLine("Ошибка: некорректный ввод!");
	return;
}

int num = Convert.ToInt32(str);

int square = num * num;

Console.WriteLine($"Квадрат числа {num} = {square}");

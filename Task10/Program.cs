// 16.Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Проверка, является ли одно число квадратом другого.");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"{num1}, {num2}");
if (IsSquareEachOther(num1, num2))
	Console.WriteLine($" -> Да");
else
	Console.WriteLine($" -> Нет");

bool IsSquareEachOther(int a, int b)
{
	return a == b * b || b == a * a;
}

// 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

int a;
bool isNotInRange;
do
{
	Console.WriteLine("Введите трехзначное число: ");
	a = Convert.ToInt32(Console.ReadLine());
	isNotInRange = a < 100 || a > 999;
	if (isNotInRange)
		Console.WriteLine("Ошибка: введено не трёхзначное число! Повторите ввод.");

} while (isNotInRange);

Console.WriteLine($"Последняя цифра числа {a} = {a % 10}");

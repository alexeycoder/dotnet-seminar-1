// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает
// последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

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

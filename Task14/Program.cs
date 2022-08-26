// 14.Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Проверка числа на кратность одновременно 7 и 23.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool IsMultiple(int num, int a, int b)
{
	return num % a == 0 && num % b == 0;
}

Console.Write(number);
if (IsMultiple(number, 7, 23))
	Console.WriteLine(" -> Да");
else
	Console.WriteLine(" -> Нет");

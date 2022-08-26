// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarterId = Convert.ToInt32(Console.ReadLine());

string GetRangeStr(int qur)
{
	string res = "Допустимый диапазон координат: ";
	if (qur == 1) return res + "x > 0, y > 0";
	if (qur == 2) return res + "x < 0, y > 0";
	if (qur == 3) return res + "x < 0, y < 0";
	if (qur == 4) return res + "x > 0, y < 0";
	return "Некорректный номер четверти";
}

Console.WriteLine(GetRangeStr(quarterId));

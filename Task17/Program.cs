// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X != 0 и Y != 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки: ");
Console.Write("X: ");
int ux = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int uy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetQuarter(ux, uy));

static string GetQuarter(int x, int y)
{
	if (x > 0 && y > 0)
		return "Первая четверть";
	else if (x < 0 && y > 0)
		return "Вторая четверть";
	else if (x < 0 && y < 0)
		return "Третья четверть";
	else if (x > 0 && y < 0)
		return "Четвёртая четверть";
	else if (x == 0 && y == 0)
		return "Центр координат";
	else if (x == 0)
		return "Точка лежит на оси Y";
	else // if (y == 0)
		return "Точка лежит на оси X";
}

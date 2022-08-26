// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
decimal numberA = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
decimal numberB = Convert.ToDecimal(Console.ReadLine());

decimal remainder = numberA % numberB;

if (remainder == 0)
	Console.WriteLine($"Число {numberA} кратно числу {numberB}");
else
	Console.WriteLine($"Число {numberA} не кратно числу {numberB}");

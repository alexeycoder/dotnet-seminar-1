// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int[] sides = new int[3];

Console.WriteLine("Задайте длины сторон предполагаемого треугольника:");
for (int i = 0; i < sides.Length; ++i)
{
	Console.Write($"Длина {i + 1}-й стороны: ");
	sides[i] = Convert.ToInt32(Console.ReadLine());
}

bool isValid = IsValidTriangle(sides);

Console.WriteLine(isValid ? "Треугольник с такими сторонами может существовать." : "Невозможно существование треугольнака с заданными сторонами.");

// Methods

static bool IsValidTriangle(int[] lengths)
{
	int maxLength = lengths[0];
	if (lengths[1] > maxLength) maxLength = lengths[1];
	if (lengths[2] > maxLength) maxLength = lengths[2];

	return lengths[0] + lengths[1] + lengths[2] - maxLength > maxLength;
}

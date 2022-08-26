// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

var mtx = CreateMatrixRandomInt(m, n);
PrintMatrix(mtx);

int[,] CreateMatrixRandomInt(int rows, int cols)
{
	int[,] matrix = new int[rows, cols];

	Random rnd = new Random();
	for (int row = 0; row < rows; ++row)
	{
		for (int col = 0; col < cols; ++col)
		{
			matrix[row, col] = row + col;
		}
	}
	return matrix;
}

int[,] PrintMatrix(int[,] matrix)
{
	int rowsLastIndex = matrix.GetLength(0) - 1;
	int colsLastIndex = matrix.GetLength(1) - 1;
	for (int row = 0; row <= rowsLastIndex; ++row)
	{
		Console.Write("[");
		for (int col = 0; col < colsLastIndex; ++col)
		{
			Console.Write($"{matrix[row, col],3}, ");
		}
		Console.WriteLine($"{matrix[row, colsLastIndex],3}]");
	}
	return matrix;
}

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

var mtx = CreateMatrixRandomInt(m, n, 0, 10);

Console.WriteLine();
Console.WriteLine("Исходная матрица:");
PrintMatrix(mtx);

Console.WriteLine();
Console.WriteLine("Модифицированная матрица:");
SquareByFullEvenIndexes(mtx);
PrintMatrix(mtx);

void SquareByFullEvenIndexes(int[,] matrix)
{
	int rowsLastIndex = matrix.GetLength(0) - 1;
	int colsLastIndex = matrix.GetLength(1) - 1;

	for (int row = 0; row <= rowsLastIndex; row = row + 2)
	{
		for (int col = 0; col <= colsLastIndex; col = col + 2)
		{
			matrix[row, col] *= matrix[row, col];
		}
	}
}

int[,] CreateMatrixRandomInt(int rows, int cols, int min, int max)
{
	int[,] matrix = new int[rows, cols];

	Random rnd = new Random();
	++max;
	for (int row = 0; row < rows; ++row)
	{
		for (int col = 0; col < cols; ++col)
		{
			matrix[row, col] = rnd.Next(min, max);
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

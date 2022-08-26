// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

var mtx = CreateMatrixRandomInt(5, 10, -99, 99);
PrintMatrix(mtx);


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
			Console.Write($"{matrix[row, col],4}, ");
		}
		Console.WriteLine($"{matrix[row, colsLastIndex],4}]");
	}
	return matrix;
}

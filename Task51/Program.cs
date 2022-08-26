// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

var mtx = CreateMatrixRandomInt(m, n, 0, 10);
PrintMatrix(mtx);

int mainDiagSum = CalcMainDiagonalSum(mtx);
int secondaryDiagBottomLeftSum = CalcSecondaryBottomLeftDiagonalSum(mtx);
int secondaryDiagTopRightSum = CalcSecondaryTopRightDiagonalSum(mtx);

Console.WriteLine($"Сумма элементов по главной диагонали = {mainDiagSum}");
Console.WriteLine($"Сумма элементов по побочной диагонали с началом в нижнем левом углу = {secondaryDiagBottomLeftSum}");
Console.WriteLine($"Сумма элементов по побочной диагонали с началом в верхнем правом углу = {secondaryDiagTopRightSum}");

// Principal Diag (from TOP LEFT)
int CalcMainDiagonalSum(int[,] matrix)
{
	int sum = 0;
	for (int i = 0; i < Math.Min(matrix.GetLength(0), matrix.GetLength(1)); ++i)
	{
		sum += matrix[i, i];
	}
	return sum;
}

// Secondary V1 - from BOTTOM LEFT
int CalcSecondaryBottomLeftDiagonalSum(int[,] matrix)
{
	int rowsLastIndex = matrix.GetLength(0) - 1;
	int colsLastIndex = matrix.GetLength(1) - 1;
	int diagonalIndex = Math.Min(rowsLastIndex, colsLastIndex);

	int sum = 0;
	for (int row = rowsLastIndex, col = 0; col <= diagonalIndex && row >= 0; row--, ++col)
	{
		sum += matrix[row, col];
	}
	return sum;
}

// Secondary V2 - from TOP RIGHT
int CalcSecondaryTopRightDiagonalSum(int[,] matrix)
{
	int rowsLastIndex = matrix.GetLength(0) - 1;
	int colsLastIndex = matrix.GetLength(1) - 1;
	int diagonalIndex = Math.Min(rowsLastIndex, colsLastIndex);

	int sum = 0;
	for (int row = 0, col = colsLastIndex; col >= 0 && row <= diagonalIndex; ++row, --col)
	{
		sum += matrix[row, col];
	}
	return sum;
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
			Console.Write($"{matrix[row, col],4}, ");
		}
		Console.WriteLine($"{matrix[row, colsLastIndex],4}]");
	}
	return matrix;
}

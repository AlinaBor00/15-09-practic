// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.


double[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   // rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // columns (1)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1, MidpointRounding.ToZero);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}

double [,] array2D = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2D);

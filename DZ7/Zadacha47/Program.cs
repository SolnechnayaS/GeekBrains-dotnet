// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.WriteLine();
Console.Write("Введи количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 2);

        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
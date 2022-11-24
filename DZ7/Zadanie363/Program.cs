// №363. Даны числа n и m. Создайте массив A[n][m] и заполните его змейкой (см. пример).
Console.Clear();
Console.WriteLine("Даны числа n и m. Создайте массив A[n][m] и заполните его змейкой (см. пример).");
Console.WriteLine();
Console.Write("Введи количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи шаг матрицы: ");
int Shag = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи старт змейки: ");
int Start = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix, int Shag, int Start)
{
    int m = matrix.GetLength(1);

    for (int j = 1; j < m; j++)
    {
        matrix[0, 0] = Start;
        matrix[0, j] = matrix[0, j - 1] + Shag;
        matrix[1, 0] = 2 * Shag * m - Shag + Start;
        matrix[1, j] = matrix[1, j - 1] - Shag;
    }

    for (int i = 2; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrix[i - 2, j] + 2 * Shag * m;
        }
    }
}

void PrintMatrix(int[,] matrix)
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

int[,] matrix = new int[n, m];

FillMatrix(matrix, Shag, Start);
PrintMatrix(matrix);
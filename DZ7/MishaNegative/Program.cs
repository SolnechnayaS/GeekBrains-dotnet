Console.Clear();
Console.WriteLine("Требуется написать программу, которая в качестве входных данных использует исходное бинарное черно-белое изображение и полученный Мишиной программой негатив, и на основе этого определяет количество пикселей, в которых допущена ошибка.");
Console.WriteLine();
Console.Write("Введи количество строк изображения: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов изображения: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 2);

        }
    }
}

void CreateNegative(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) matrix[i, j] = 1;
            else matrix[i, j] = 0;

        }
    }
}

void CreateError(int[,] matrix)
{
    int MaxSumError = new Random().Next(0, (matrix.GetLength(0) * matrix.GetLength(1)));
    for (int E = 0; E < MaxSumError; E++)
    {
        int i = new Random().Next(0, matrix.GetLength(0));
        int j = new Random().Next(0, matrix.GetLength(1));
        if (matrix[i, j] == 1)
        {
            matrix[i, j] = 0;
        }
        else matrix[i, j] = 1;
    }
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == 0) Console.Write("B");
            else Console.Write("W");
        }
        Console.WriteLine();
    }
}

void CompareMatrix(int[,] matrix1, int[,] matrix2)
{
    int count = 0;
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if ((matrix1[i, j] == 0 && matrix2[i, j] == 1) || (matrix1[i, j] == 1 && matrix2[i, j] == 0));
            else count++;
        }
    }
    Console.WriteLine($"Количество ошибок в негативе: {count}");
}

int[,] matrix = new int[n, m];
FillMatrix(matrix);

int[,] newmatrix = matrix.Clone() as int[,];
CreateNegative(newmatrix);
CreateError(newmatrix);

PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(newmatrix);
Console.WriteLine();
CompareMatrix(matrix, newmatrix);
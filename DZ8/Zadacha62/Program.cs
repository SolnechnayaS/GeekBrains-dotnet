// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Console.Clear();
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив");

Console.WriteLine();
Console.Write("Введи размер квадратной матрицы (число строк или столбцов): ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи шаг матрицы: ");
int Shag = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи старт змейки: ");
int Start = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix, int Start, int Shag)
{
    int N = matrix.GetLength(0);

    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

    int k = Start;
    int i = 0;
    int j = 0;

    while (k <= Start+N*N*Shag-Shag)
    {
        matrix[i, j] = k;
        if (i == Ibeg && j < N - Jfin - 1)
            j++;
        else if (j == N - Jfin - 1 && i < N - Ifin - 1)
            i++;
        else if (i == N - Ifin - 1 && j > Jbeg)
            j--;
        else
            i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != N - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k = k+Shag;
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

int[,] matrix = new int[n, n];

FillMatrix(matrix, Start, Shag);
PrintMatrix(matrix);
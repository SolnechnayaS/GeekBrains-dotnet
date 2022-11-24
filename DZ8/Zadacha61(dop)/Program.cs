// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
Console.Clear();
Console.WriteLine("Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника");

Console.WriteLine();
Console.Write("Введи число строк треугольника Паскаля: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0 || j == i)
            {
                matrix[i, j] = 1;
            }

            else if (j < i)
            {
                matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
            }

            else
            {
                matrix[i, j] = 0;
            }

        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] != 0)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[n, n];

FillMatrix(matrix);
PrintMatrix(matrix);
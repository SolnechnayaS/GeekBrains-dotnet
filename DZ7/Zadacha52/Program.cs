// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine();
Console.Write("Введи количество столбцов в заданном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество строк в заданном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-99, 100);
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

void ColumnSum(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    double[] array2 = new double[matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] = array[j] + matrix[i, j];
            array2[j] = Math.Round((array[j] / matrix.GetLength(0)), 2);
        }
    }
    Console.WriteLine($"{string.Join(" \t", array2)}");
}

int[,] matrix = new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);

Console.WriteLine("Среднее значение по каждому столбцу: ");
ColumnSum(matrix);
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine();
Console.Write("Введи количество строк в заданном массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов в заданном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble() * 100, 1);

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
void ElementMatrix(double[,] matrix)
{

    Console.Write("Введи номер строки для поиска элемента: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введи номер столбца для поиска элемента: ");
    int j = Convert.ToInt32(Console.ReadLine());
    if (i > matrix.GetLength(0) || j > matrix.GetLength(1) || i <= 0 || j <= 0)
    {
        Console.WriteLine("Элемент на данной позиции не существует");
    }
    else
    {
        Console.WriteLine($"Искомый элемент в {i} строке и {j} столбце: {matrix[(i - 1), (j - 1)]}");
    }
}

double[,] matrix = new double[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
ElementMatrix(matrix);
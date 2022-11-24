// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);

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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} \t");
    }
}

void LineSum(int[,] matrix, int[] array)
{

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[i] = array[i] + matrix[i, j];

        }
    }
}

int[,] matrix = new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);

int[] array = new int[n];

Console.WriteLine("Сумма по каждой строке: ");
LineSum(matrix, array);
PrintArray(array);

int MimimumSumInLine(int[] array)
{
    int minSumLine = 0;
    int MinSum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < MinSum)
        {
            MinSum = array[i];
            minSumLine = i;
        }
    }
    return minSumLine;
}

Console.WriteLine($"Индекс строки с наименьшей суммой элементов {MimimumSumInLine(array)}");
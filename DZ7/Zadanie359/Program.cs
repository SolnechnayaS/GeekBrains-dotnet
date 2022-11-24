// №359. В метании молота состязается n спортcменов. Каждый из них сделал m бросков. Победитель определяется по лучшему результату. Определите количество участников состязаний, которые разделили первое место, то есть определите количество строк в массиве, которые содержат значение, равное наибольшему.
Console.Clear();
Console.WriteLine("В метании молота состязается n спортcменов. Каждый из них сделал m бросков. Победителем соревнований объявляется тот спортсмен, у которого максимален наилучший результат по всем броскам. Таким образом, программа должна найти значение максимального элемента в данном массиве, а также его индексы (то есть номер спортсмена и номер попытки).");
Console.WriteLine();
Console.Write("Введи количество попыток каждого спортсмена: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество спортсменов: ");
int n = Convert.ToInt32(Console.ReadLine());

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

void MaximumMatrix(int[,] matrix)
{
    int maxZnachenie = 0;
    int maxIndexI = 0;
    int maxIndexCount = 1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] > maxZnachenie)
            {
                maxZnachenie = matrix[i, j];
                maxIndexI = i;
            }
        }

    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] == maxZnachenie && i > maxIndexI)
            {
                maxIndexCount++;
                break;
            }
        }

    }
    Console.WriteLine($"Рекорд составил {maxZnachenie} у {maxIndexCount} спортсменов");
}

int[,] matrix = new int[n, m];
FillMatrix(matrix);
PrintMatrix(matrix);
MaximumMatrix(matrix);
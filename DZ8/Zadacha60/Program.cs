// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();
Console.WriteLine("Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

Console.Write("Введите параметры трехмерного массива: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int k = int.Parse(num[2]);



void FillArray(int[] array)
{
    array[0] = 10;
    for (int i = 1; i < array.Length; i++)
    {
        array[i] = array[i - 1] + 1;
    }
}

void Fill3DMatrix(int[,,] matrix, int[] array)
{
    int arrayIndexRandom = new Random().Next((matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)), array.Length);
    int x = array[arrayIndexRandom];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = x - count;
                count++;
            }
        }
    }
}

void Print3DMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

if (n * m * k > 90)
{
    Console.WriteLine("Извини, размеры матрицы превышают количество существующих неповторяющихся двузначных чисел! Не могу заполнить предложенную матрицу уникальными значениями");
}

else
{
    int[] arrayTwoDigitNumber = new int[90];
    FillArray(arrayTwoDigitNumber);

    int[,,] matrix3D = new int[n, m, k];
    Fill3DMatrix(matrix3D, arrayTwoDigitNumber);
    Print3DMatrix(matrix3D);
}
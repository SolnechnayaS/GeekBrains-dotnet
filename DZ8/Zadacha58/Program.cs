// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Clear();
Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

Console.Write("Введите кол-во строк и столбцов первой матрицы: ");
string[] num1 = Console.ReadLine().Split(' ');
int n1 = int.Parse(num1[0]);
int m = int.Parse(num1[1]);

int[,] firstMartrix = new int[n1, m];

FillMatrix(firstMartrix);
PrintMatrix(firstMartrix);

Console.Write("Введите кол-во строк и столбцов второй матрицы: ");
string[] num2 = Console.ReadLine().Split(' ');
int k = int.Parse(num2[0]);
int n2 = int.Parse(num2[1]);

int[,] secondMartrix = new int[k, n2];

FillMatrix(secondMartrix);
PrintMatrix(secondMartrix);


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum = sum + firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

if (n1 != n2)
{
    Console.WriteLine("Число строк первой матрицы не совпадает с числом столбцов второй матрицы, матрицы перемножить нельзя!");
}

else
{
    int[,] multiplyMatrix = new int[n1, n2];
    MultiplyMatrix(firstMartrix, secondMartrix, multiplyMatrix);
    Console.WriteLine("Математическое произведение матриц:");
    PrintMatrix(multiplyMatrix);
}
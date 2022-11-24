// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.Write ("Задай длину массива: ");

int N = Convert.ToInt32 (Console.ReadLine ());

void FillArray(int [] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index]= new Random().Next(100,1000);
        ;
    }
}

void PrintArray(int [] collection)
{
    int index = 0; 
    while (index < collection.Length)
    {index++;}
        Console.WriteLine($"Массив случайных чисел:[{string.Join(", ", collection)}]");
}

void SumOddPos(int [] collection)
{
    int sum = 0;

    for (int index = 0; index < collection.Length; index++)
    {
        if (index%2==1)
        sum=sum+collection[index];
    }
        Console.WriteLine($"Сумма нечетных элементов в заданном массиве: {sum}");
    
}

int[] massiv1 = new int[N];
FillArray(massiv1);
PrintArray(massiv1);
SumOddPos(massiv1);
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.Write ("Задай длину массива: ");

int N = Convert.ToInt32 (Console.ReadLine ());

void FillArray(double [] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index]= new Random().Next(100,1000);
    }
}

void PrintArray(double [] collection)
{
    int index = 0; 
    while (index < collection.Length)
    {index++;}
        Console.WriteLine($"Массив случайных чисел:[{string.Join(", ", collection)}]");
}


double[] massiv1 = new double[N];

void Razn(double [] collection)
{
    double Maximum = collection[0];
    double Minimum = collection[0];
    for (int index = 1; index < collection.Length; index++)
    {
        if (collection[index]>Maximum)
        Maximum=collection[index];
   else if (collection[index]<Minimum)
        Minimum=collection[index];
    }
    Console.WriteLine($"Разница между Максимальным и Минимальным значениями {Maximum-Minimum}");
}

FillArray(massiv1);
PrintArray(massiv1);
Razn(massiv1);
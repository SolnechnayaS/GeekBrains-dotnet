// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

int [] array = new int [8];

for (int i=0; i<array.Length;i++)
{
Console.Write ($"Задай элемент №{i+1}:    ");
array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Массив[{string.Join(", ", array)}]");
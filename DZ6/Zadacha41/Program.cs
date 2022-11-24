Console.Clear();
Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write ("Укажи, сколько чисел планируешь ввести? ");
int M = Convert.ToInt32(Console.ReadLine());

void FillArray (int [] array)
{
    for (int i=0; i < array.Length; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());
}

void PrintArray (int [] array)
{
    Console.Write ($"[{String.Join(", ", array)}]");
}

int [] massiv = new int [M];
Console.WriteLine("Введи числа через Enter:");

FillArray(massiv);
PrintArray(massiv);

void PositiveNumber (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i]>0) count++;
    Console.WriteLine ($"Введено {count} числа больше нуля");
}

Console.WriteLine();
PositiveNumber(massiv);
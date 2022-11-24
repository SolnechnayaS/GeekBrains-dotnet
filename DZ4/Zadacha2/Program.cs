// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.Write ("Задайте входящее число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (N>0)
{
result = result + N%10;
N = N/10;
}

Console.WriteLine($"Сумма всех цифр заданного числа: {result}");
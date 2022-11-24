// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.Write ("Задай число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Задай число B: ");
int B = Convert.ToInt32 (Console.ReadLine());

int result = a;
for (int i = 1; i<B; i++)
result = result * a;

Console.WriteLine($"A в степени B равно = {result}");
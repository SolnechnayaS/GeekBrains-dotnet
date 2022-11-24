Console.Clear();
Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.Write ("Введите целое трехзначное число ");
int a = Convert.ToInt32 (Console.ReadLine ());
if (Math.Abs(a)>99 && Math.Abs(a)<1000)
Console.WriteLine($"Вторая цифра из введенного трехзначного числа {(Math.Abs(a)%100-Math.Abs(a)%10)/10}");
else 
{Console.WriteLine("Будьте внимательнее! Вы ввели не трехзначное число");
Console.Write ("Введите целое трехзначное число ");
int b = Convert.ToInt32 (Console.ReadLine ());
if (Math.Abs(b)>99 && Math.Abs(b)<1000)
Console.WriteLine($"Вторая цифра из введенного трехзначного числа {(Math.Abs(b)%100-Math.Abs(b)%10)/10}");}
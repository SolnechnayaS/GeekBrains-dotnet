Console.Clear ();
Console.WriteLine("Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.Write ("Введите пятизначное число: ");
string array = Console.ReadLine();
int n = array.Length;
if (n>5||n<5)
Console.WriteLine("Вы ввели не пятизначное число");
else
{
    if (array[0]==array[n-1]&&array[1]==array[n-2]&&array[2]==array[n-3])
    Console.WriteLine("Введенное число является палиндромом");
    else
    Console.WriteLine("Введенное число не палиндром");
};
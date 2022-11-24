Console.Clear();
Console.WriteLine("Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.Write ("Введите целое число ");
string array = Console​.ReadLine();
if (array.Length<3)
Console.WriteLine ("Нет третьей цифры");
else
Console.WriteLine ($"Третья цифра {array[2]}");
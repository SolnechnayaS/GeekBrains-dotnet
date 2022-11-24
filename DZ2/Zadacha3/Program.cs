Console.Clear();
Console.WriteLine("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write ("Введите номер дня недели ");
int a = Convert.ToInt32 (Console.ReadLine ());
if (a<1||a>7)
{
    Console.WriteLine ("Вы ввели неверный номер дня недели");
    Console.Write ("Введите номер дня недели в интервале от 1 до 7 ");
    int b = Convert.ToInt32 (Console.ReadLine ());
    if (b<1||b>7)
    Console.WriteLine ("Вы ПОВТОРНО ввели неверный номер дня недели");
    else 
    {
        if (b>5)
        Console.WriteLine ("Это выходной день");
        else
        Console.WriteLine ("Это рабочий день");
    }
}
else 
{if (a>5)
Console.WriteLine ("Это выходной день");
else
Console.WriteLine ("Это рабочий день");
}
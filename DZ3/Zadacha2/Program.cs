Console.Clear();
Console.WriteLine("Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine ("Введите координаты первой точки");
Console.Write("A(x) ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("A(y) ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("A(z) ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки");
Console.Write("B(x) ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("B(y) ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("B(z) ");
double zb = Convert.ToDouble(Console.ReadLine());

Console.WriteLine ($"Расстояние между точками составляет {Math.Round(Math.Sqrt((xa-xb)*(xa-xb)+(ya-yb)*(ya-yb)+(za-zb)*(za-zb)), 2)}");

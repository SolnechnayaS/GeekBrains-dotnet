// Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
Console.Clear();
Console.Write ("Введите длину последовательности: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N];
array[N-1] = 0;
for (int i=0; i<array.Length-1; i++)
array[i] = new Random().Next(0,101);

Console.WriteLine($"[{string.Join(", ", array)}]");

int result1 = 0;
for (int i=0; i<array.Length; i++)
{
if  (array[i]>result1)
result1 = array[i];
}
Console.WriteLine($"Максимальное значение последовательности {result1}");

int result2 = 0;
for (int i=0; i<array.Length; i++)
{
if  (array[i]>result2 && array[i]<result1 )
result2 = array[i];
}

Console.WriteLine($"Второе максимальное значение последовательности {result2}");
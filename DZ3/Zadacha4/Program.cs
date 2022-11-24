Console.Clear ();
Console.WriteLine("Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.");
Console.Write ("Введите число кустов черники на грядке: ");
int N = Convert.ToInt32 (Console.ReadLine ());

void PrintArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    
    while (index < length)
    {
        Console.Write ($"{collection[index]} ");
        index++;
    }
}

void FillArray(int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random().Next(1,1000);
        index++;
    }
}

int[] kust = new int[N];
FillArray(kust);

Console.Write ("Урожай черники: ");
PrintArray(kust);

void FillArray2(int [] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < N-2)
    {
        collection[i]= kust[i]+kust[i+1]+kust[i+2];
        i++;
    }
}

int[] a = new int[N-2];
FillArray2(a);

Console.WriteLine ("");
Console.Write ("Сумма урожая по соседним кустам черники: ");

PrintArray(a);

int b = kust[N-2]+kust[N-1]+kust[0];
int c = kust[N-1]+kust[1]+kust[0];

Console.Write ($"{b} {c}");
Console.WriteLine ("");

int a_max = a.Max();

int Maximum (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result=arg2;
    if (arg3>result) result=arg3;
    return result;
}

int max = Maximum(a_max,b,c);
Console.WriteLine ($"Максимальный урожай за один заход собирающего модуля: {max}");
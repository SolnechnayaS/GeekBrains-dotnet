// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.
// Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).
Console.Clear();
Console.WriteLine("Задай длину массива N: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] massiv1 = new int [N];
void FillArray(int [] collection)
{
    for (int index = 0; index < collection.Length; index++)
    {
        collection[index]= new Random().Next(-100,101);
    }
}
FillArray(massiv1);

void PrintArray(int [] collection)
{
    int index = 0;
    
    while (index < collection.Length)
    {
        index++;
    }
        Console.WriteLine($"Массив случайных чисел:[{string.Join(", ", collection)}]");
    
}

PrintArray(massiv1);

Console.WriteLine("Задай смещение массива K: ");

void Offset (int [] collection)
{
    int K = Convert.ToInt32(Console.ReadLine())*(-1);
    // Умножение на -1 здесь потому, что сначала я записала весь код (рабочий), а потом оказалось что делала смещение не в ту сторону. Чтобы не переписывать полностью все условия, будет *(-1) к вводимой переменной :)))
    int N = collection.Length;
    int [] newcollection = new int [N];
    if (K>0)
    {
        for (int i = 0; i < N; i++)
        {
            if (K+i<N)
            newcollection[i] = collection[i+K];
            else 
            newcollection[i]=collection[-N+K+i];
        }
    }
    else
    {
        for (int i = 0; i < N; i++)
        {
            if (K+i<0)
            newcollection[i] = collection[N+i+K];
            else
            newcollection[i]=collection[K+i];
        }
    }

Console.WriteLine($"Массив случайных чисел:[{string.Join(", ", newcollection)}]");

}

Offset(massiv1);
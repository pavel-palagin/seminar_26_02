// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(1, 10);
    }
    return answer;
}

void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");
    }
    Console.Write(collect[collect.Length - 1] + "]");
}

int SumOddIndex (int[] array)
{
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 > 0)
    {
        sum = sum + array[i];
    }
}
return sum;
}


int N = Promt("Введите размер массива: ");
int[] arr = RandArray(N);

PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях, равно: {SumOddIndex(arr)}");



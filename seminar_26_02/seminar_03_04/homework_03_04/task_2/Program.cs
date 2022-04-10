// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[,] FillArray(int row, int coloumn)
{
    int[,] array = new int[row, coloumn];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int Row = Promt("Введите количество строк массива: ");
int Coloumn = Promt("Введите количество колонок массива: ");

int[,] array = FillArray(Row, Coloumn);

PrintArray(array);



int[] sum = new int[Row];
int min = sum[0];
for (int i = 0; i < Row; i++)
{
    for (int j = 0; j < Coloumn; j++)
    {
        sum[i] += array[i, j];
    }
    Console.WriteLine($"Сумма {i + 1} ряда массива {sum[i]}" + "\t");
}

int minSumRow = sum[0];
int index = 0;
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < minSumRow)
    {
        minSumRow = sum[i];
        index = i;
    }
}

Console.WriteLine($"Минимальная сумма находится в ряду: {index + 1}" + "\t");


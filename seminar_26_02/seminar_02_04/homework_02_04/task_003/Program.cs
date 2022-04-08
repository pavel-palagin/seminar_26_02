// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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


int R = Promt("Введите количество строк массива: ");
int C = Promt("Введите количество колонок массива: ");

int[,] array = FillArray(R, C);

PrintArray(array);



double[] sum = new double[C];

for (int i = 0; i < R; i++)
{
    for (int j = 0; j < C; j++)
    {
        sum[i] = sum[i] + array[j, i];
    }
    double res = sum[i]/C;
    
    Console.Write($"{res:0.00}" + " ");
}

Console.WriteLine();







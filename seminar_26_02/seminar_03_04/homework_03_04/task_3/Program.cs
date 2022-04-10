// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


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


int A = Promt("Введите количество строк 1ой матрицы: ");
int B = Promt("Введите количество колонок 1ой матрицы: ");

int C = Promt("Введите количество строк 2ой матрицы: ");
int D = Promt("Введите количество колонок 2ой матрицы: ");

int[,] array = FillArray(A, B);

int[,] arr = FillArray(C, D);

PrintArray(array);
Console.WriteLine("");
PrintArray(arr);
Console.WriteLine("");

int[,] Proiz(int[,] array, int[,] arr)
{
    int[,] result = new int[array.GetLength(0), arr.GetLength(1)];
    if (array.GetLength(1) == arr.GetLength(0))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = 0; k < arr.GetLength(0); k++)
                {
                    result[i, j] += array[i, k] * arr[k, j];
                }
            }
        }
    }
    else Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число столбцов в первом сомножителе равно числу строк во втором");
    return result;
}

PrintArray(Proiz(array, arr));


// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

double[,] FillArray(int row, int coloumn)
{
    double[,] array = new double[row, coloumn];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rnd.Next(0, 100)/10.0);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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

int a = Promt("Введите количество строк массива: ");
int b = Promt("Введите количество колонок массива: ");

double[,] array = FillArray(a, b);
PrintArray(array);

// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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
            array[i, j] = rnd.Next(0, 100);
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


void Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = j;
            for (int k = j; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, max]) max = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, max];
            array[i, max] = temp;
        }
    }
}



// void Sort(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] > array[i, array.GetLength(0) - j - 1])
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[i, array.GetLength(1) - j - 1];
//                 array[i, array.GetLength(1) - j - 1] = temp;
//             }
//         }
//     }
// }


int a = Promt("Введите количество строк массива: ");
int b = Promt("Введите количество колонок массива: ");


int[,] array = FillArray(a, b);
PrintArray(array);
Console.WriteLine();
Sort(array);
PrintArray(array);



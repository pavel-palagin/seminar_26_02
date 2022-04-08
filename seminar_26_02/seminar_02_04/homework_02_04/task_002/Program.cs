// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void FindPos(int[,] array)
{
    int x = Promt("Введите позицию элемента в строке: ");
    int y = Promt("Введите позицию элемента в колонке: ");

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (x - 1 == i && y - 1 == j) Console.Write($"Значение элемента в указанной позиции: {array[i, j]}\t");
            if (x - 1 > i && y - 1 > j) Console.Write("Указанная позиция выходит за пределы массива");
            
         // if (x - 1 > array.GetLength(0) && y - 1 > array.GetLength(1)) Console.Write("Указанная позиция выходит за пределы массива");

        }

    }
}

int R = Promt("Введите количество строк массива: ");
int C = Promt("Введите количество колонок массива: ");

int[,] array = FillArray(R, C);

PrintArray(array);

FindPos(array);






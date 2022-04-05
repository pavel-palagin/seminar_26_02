// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали,
// или напишите, что такого элемента нет.


int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
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

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}



void FindEnter(int[,] array)
{
    int N = Promt("Введите число: ");
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N)
            {
                Console.WriteLine($"Позиция вхождения элемента: [{i + 1},{j + 1}]");
            }
            if (array[i, j] != N) 
            {
                count++;
                if (count == array.Length) Console.WriteLine($"Нет такого элемента");
                
            }
        }

    }
    //Console.WriteLine();
}


int[,] array = FillArray(3, 3);
PrintArray(array);

Console.WriteLine();
FindEnter(array);









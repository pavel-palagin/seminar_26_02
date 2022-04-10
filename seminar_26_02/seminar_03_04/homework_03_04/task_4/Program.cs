// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int elem = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        elem = elem + i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            elem = elem + j;
            for (int k = 0; k < array.GetLength(2); k++)
            {
                elem = elem + k;
                array[i, j, k] = elem;
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}\t");
            }

        }
        Console.WriteLine();
    }
}

int[,,] array = FillArray(2,2,2);

PrintArray(array);
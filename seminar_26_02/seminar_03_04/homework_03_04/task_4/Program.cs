// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int value = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        value = value + i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            value = value + j;
            for (int k = 0; k < array.GetLength(2); k++)
            {
                value = value + k;
                array[i, j, k] = value;
                Console.WriteLine($"{i}, {j}, {k}: {value}");
            }
        }
    }
    return array;
}


int[,,] array = FillArray(1,6,1);


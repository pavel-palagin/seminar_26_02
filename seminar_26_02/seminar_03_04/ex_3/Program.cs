// Задача 3: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается 
//элемент входных данных.

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




// for (int count = 0; count < array.Length; count++)
// {
//     for (int k = 0; k < 10; k++)
//     {
//         if (array[i,j] == k) Console.WriteLine($"{k} - {count} раз");
//     }

// }

int[] FreqElem(int[,] array)
{
    int[] arr = new int[10];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            arr[array[i, j]]++;

        }
    }
    return arr;
}






int[,] array = FillArray(3, 4);
PrintArray(array);


Console.WriteLine();
//FreqElem(array);
int[] OutArr = FreqElem(array);

PrintArray(OutArr);

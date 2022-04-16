// Задача 3: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, 
//которые занимают числа из массива info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные:

// info = {2, 3, 3, 1 }
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }

// выходные данные:
// 1, 7, 0, 1

// int[] RandArray(int lenght)
// {
//     int[] answer = new int[lenght];
//     for (int i = 0; i < lenght; i++)
//     {
//         answer[i] = new Random().Next();
//     }
//     return answer;
// }

void PrintArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}

void BinToDec(int[] data, int[] info, int indexData = 0, int count = 0)
{
    if (indexData >= data.Length) return;
    int indexInfo = info[count];
    int temp = 0;
    for (int i = 0; i < indexInfo; i++)
    {
        temp = temp + data[indexData + indexInfo - i - 1] * Degree(i);
    }
    Console.Write(temp + " ");

    BinToDec(data, info, indexData + indexInfo, count + 1);
}

int Degree(int a)
{
    if (a <= 0) return 1;
    return 2 * Degree(a - 1);
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

BinToDec(data, info);


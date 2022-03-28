// Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых 
//лежат в отрезке [10,99].


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length - 1; i++)
    {
        Console.Write(collection[i] + ", ");
    }
    Console.Write(collection[collection.Length - 1] + "]");
}

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(0, 1000);
    }
    return answer;
}

int FindCol(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] <= 99 && arr[i] >= 10)
        count++;
    }
    return count;

}

int len = Promt("Введите размер массива: ");
if (len != 123) Console.WriteLine("Длина массива должна быть 123!!!");
else 
{
    int[] arr = RandArray(len);

PrintArray(arr);
Console.WriteLine();

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] равно {FindCol(arr)}");
}

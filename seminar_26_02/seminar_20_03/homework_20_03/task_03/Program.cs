// Задача 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
//Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Promt("Введите размер массива: ");


void AddArray(int[] array)
{
    
    Random value = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = value.Next(0, 100);
    }
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write(collection[index] + ", ");
    }
    Console.Write(collection[N-1] + "]");
}

int[] array = new int[N];

AddArray(array);
PrintArray(array);
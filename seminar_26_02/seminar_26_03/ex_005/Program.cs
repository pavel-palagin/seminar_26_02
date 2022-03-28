// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний 
//и т.д. Результат запишите в новом массиве.



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
        answer[i] = new Random().Next(0, 10);
    }
    return answer;
}



int[] FindCompas(int[] arr, int len)
{
    //int count = 0;
    int[] array = new int[len/2];
    //int result = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        array[i] = arr[i] * arr[arr.Length - i - 1];

    }
    return array;

}

int len = Promt("Введите размер массива: ");
int[] arr = RandArray(len);

PrintArray(arr);
Console.WriteLine();

PrintArray(FindCompas(arr, len));






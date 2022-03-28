// Напишите программу замена элементов массива: положительные 
//элементы замените на соответствующие отрицательные, и наоборот.

int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
    }
    return answer;
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

int[] Reverse(int[] arr)
{
    for(int i = 0; i <= arr.Length; i++)
    {
        arr[i] = arr[i] + (-1);
    }
    return arr;
}

int [] arr = RandArray(12);
PrintArray(arr);
int[] arr1 = Reverse(arr);
PrintArray(arr1);

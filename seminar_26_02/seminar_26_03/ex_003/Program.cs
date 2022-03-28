//  Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


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

bool FindNumber(int[] arr, int Value)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == Value)
        {
            result = true;
            break;
        }
        
    }
    return result;
}

int[] arr = RandArray(5);
PrintArray(arr);
int N = Promt("Введите число: ");

Console.WriteLine();

Console.WriteLine(FindNumber(arr, N));

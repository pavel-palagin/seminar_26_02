// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int N = Promt("Введите размер массива: ");

int[] arr = new int[N];
for (int i = 0; i < N; i++)
{
    Console.Write("Введите {0}-й элемент: ", i + 1);
    arr[i] = int.Parse(Console.ReadLine());
}

int[] CopyArray(int[] arr)
{
    int[] copy = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}

int[] copy = CopyArray(arr);

Console.WriteLine(copy);
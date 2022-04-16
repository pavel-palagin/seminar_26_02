//Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
//Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
//N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void Row(int i, int count, int N)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(i + " ");
        count++;
        if (count == N) return;
    }
    Row(i + 1, count, N);
}

int N = Promt("Введите количество значений: ");

Row(1, 0, N);

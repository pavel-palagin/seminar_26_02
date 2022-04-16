// Задача 1: Есть монотонная последовательность, каждое число 
//встречается ровно то количество раз, какое значение этого числа:
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой 
//последовательности до N-го значения, желательно использовать :
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

// void Row(int N)
// {
//     if (N == 0) return;
//     for (int i = 1; i <= N; i++)
//     {
//         Console.Write(N);
//     }
//     Row(N - 1);
// }

// void Row1(int N)
// {
//     if (N < 0) return;
//     Row1(N - 1);
//     for (int i = N; i > 0; i--)
//     {
//         Console.Write(N + " ");
//     }

// }

void Row1(int N, int count, int max)
{
    if (N < 0) return;
    for (int i = 0; i < N; i++)
    {
        Console.Write(N + " ");
        count++;
        if (count == max) return;

    }
    Row1(N + 1, count, max);


}


int N = Promt("Введите первое число: ");

Row1(1, 0, N);

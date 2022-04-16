// Задача 3: Разложите число на множители. Желательно использовать
//рекурсию: N = 12 -> "2, 2, 3"


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void Row(int N, int D)
{
    if (N / D == 0) return;
    if (N % D == 0)
    {
        Console.Write(D + " ");
        Row(N / D, D);

    }
    if (N % D != 0)
    {
        Console.Write(N + " ");
       // Row(N, D + 1);

    }
}

int N = Promt("Введите число: ");


Row(N, 2);





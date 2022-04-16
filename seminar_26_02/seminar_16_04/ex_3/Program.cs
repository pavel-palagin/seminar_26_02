// Задача 4: Разверните число при помощи рекурсии:
//N = 1234 -> "4321"

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void Reverse(int N)
{
    if (N == 0) return;
    Console.Write(N % 10);
    Reverse(N / 10);
}


int N = Promt("Введите число: ");
Reverse(N);
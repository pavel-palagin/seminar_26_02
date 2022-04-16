// Задача 2: Проверка на простое число:
//N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void Simple(int N, int D)
{
    if (N / D == 1)
    {
        Console.Write("Является простым числом");
        return;
    }
    if (N % D != 0)
    {
        Simple(N, D + 1);
    }
    else Console.Write("Не является простым числом");
}

int N = Promt("Введите число: ");

Simple(N, 2);

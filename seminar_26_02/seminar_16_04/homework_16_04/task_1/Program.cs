// Задача 1: Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void Del(int N)
{
    if (N / 2 == 0)
    {
        Console.Write("Является степень двойки");
        return;
    }
    if (N % 2 == 0)
    {
        Del(N / 2);
    }
    else Console.Write("Не является степенью двойки");
    
}

int N = Promt("Введите число: ");

Del(N);


// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintN(int M, int N)
{
    if (M > N) return;
    if (M % 2 == 0)
    {
        Console.Write(M + " ");
        PrintN(M + 2, N);
    }
    if (M % 2 != 0)
    {
        Console.Write(M + 1 + " ");
        PrintN(M + 2, N);
    }
}


int M = Promt("Число M: ");
int N = Promt("Число N: ");

PrintN(M, N);



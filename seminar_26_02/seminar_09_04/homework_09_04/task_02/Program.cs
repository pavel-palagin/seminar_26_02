// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int PrintN(int N, int M)
{
    if (N == M) return N;
    return N + PrintN(N + 1, M);
}

int N = Promt("Число N: ");
int M = Promt("Число M: ");

Console.Write(PrintN(N, M));
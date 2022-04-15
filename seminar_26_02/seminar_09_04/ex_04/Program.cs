// Задача 4: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int Degree(int N, int M)
{
    if (M == 0) return 1;
    return N * Degree(N, M - 1);
}

int N = Promt("Число N: ");
int M = Promt("Число M: ");
Console.Write(Degree(N, M));
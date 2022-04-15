//Задача 2: Задайте значения M и N. Напишите программу, которая 
//выведет все натуральные числа в промежутке от M до N.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintN(int N, int i)
{
    if (i > N) return;
    Console.Write(i + " ");
    PrintN(N, i + 1);
}

int M = Promt("Число M: ");
int N = Promt("Число N: ");

PrintN(N, M);

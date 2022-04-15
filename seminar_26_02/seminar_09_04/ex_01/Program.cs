// Задача 1: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от 1 до N.


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
    PrintN(N, i+1);
}

int N = Promt("Число N: ");

PrintN(N,1);

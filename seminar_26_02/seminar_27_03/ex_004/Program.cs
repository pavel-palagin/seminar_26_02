﻿// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


int N = Promt("Введите число: ");
int temp = N;


string b = " ";
while (N > 0)
{
    b = N % 2 + b;
    N = N / 2;

}

Console.Write($"Число {temp} в двоичном {b}");


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
string Dvoichnaya(int number)
{
    string answer = " ";
    while (number > 0)
    {
        answer = number % 2 + answer;
        number = number / 2;
    }
    return answer;
}

int number = Promt("Введите десятичное число => ");
int temp = number;
string N = Dvoichnaya(number);
Console.Write($"Число {temp} в двоичной системе => {N}");

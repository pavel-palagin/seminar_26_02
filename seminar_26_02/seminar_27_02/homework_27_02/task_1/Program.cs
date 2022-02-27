// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int n = pront("Введите число: ");
int pront(string strValue)
{
    Console.WriteLine(strValue);
    string Value = Console.ReadLine();
    int a = int.Parse(Value);
    return a;
}


int div = n / 10;          // целочисленное деление 
int ost = div % 10;        // деление с остатком


Console.WriteLine("Вторая цифра трехзначного числа: " + ost);


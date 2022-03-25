// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int number = Promt("Введите число: ");

int count = 0;
int sum = number % 10;

while (number != 0)
{
    number = number / 10;
    int ost = number % 10;
    sum = sum + ost;
    count++;
}

Console.WriteLine(sum);
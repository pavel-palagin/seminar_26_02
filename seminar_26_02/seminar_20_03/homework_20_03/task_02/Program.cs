// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


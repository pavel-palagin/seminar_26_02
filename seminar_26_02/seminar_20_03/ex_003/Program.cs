// Задача 2: Напишите программу, которая принимает на вход число N и 
//выдаёт произведение чисел от 1 до N
int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


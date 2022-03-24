// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.



int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


int A = Promt("Введите число А: ");
int B = Promt("Введите число В: ");


int count = 1;
int result = 1;

if (B >= 0)
{
    while (count <= B)
    {
    result = result * A;
    count++;
    
    }
Console.WriteLine(result);
}

if (B < 0) Console.WriteLine("Некорректное число В");


// See https://aka.ms/new-console-template for more information

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


int N = Promt("Введите число: ");


int NumberSum(int numbers)
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до {N} равна {NumberSum(N)}");

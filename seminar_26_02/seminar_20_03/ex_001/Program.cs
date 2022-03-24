// See https://aka.ms/new-console-template for more information


int digit = Promt("Введите число");
Console.WriteLine($"Сумма чисел от 1 до {digit} равна {NumberSum(digit)}")

int NumberSum(int i)
{
    int sum = 0;
    for (int i = 1; i <= digit; i++)
    {
        sum += i;
    }
    return sum;
}


int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
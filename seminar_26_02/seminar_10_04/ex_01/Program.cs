// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, для которых каждое следующее равно сумме двух предыдущих.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int a = Promt("Введите первое число: ");
int b = Promt("Введите второе число: ");
int n = Promt("Введите количество операций: ");

int Sum(int a, int b, int n)
{
    if (n == 0) return 0;
    Console.Write($"{a} ");
    return a + Sum(b, a + b, n - 1);
}

Sum(a, b, n);

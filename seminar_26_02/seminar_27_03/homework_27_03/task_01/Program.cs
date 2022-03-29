// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int n = Promt("Введите количество чисел для ввода: ");

int[] a = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write("{0}-й элемент: ", i + 1);
    a[i] = int.Parse(Console.ReadLine());
    if (a[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Чисел больше 0: {count}");


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Введите число a: ");
//string strValue1 = Console.ReadLine();
//int a = int.Parse(strValue1);

int b = pront("Введите a ");

int pront(string strValue)
{
    Console.WriteLine(strValue);
    string Value = Console.ReadLine();
    int a = int.Parse(Value);
    return a;
}

int M(int a)
{
    if (a < 0) a = -a;
    return a;
}

Console.WriteLine(M(b));

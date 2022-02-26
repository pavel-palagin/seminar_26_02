Console.WriteLine("Введите число a: ");
string strA = Console.ReadLine();
int a = int.Parse(strA);

Console.WriteLine("Введите число b: ");
string strB = Console.ReadLine();
int b = int.Parse(strB);

if (a > b)
{
    Console.WriteLine("max ="+ a);
    Console.WriteLine("min ="+ b);
}

else
{
    Console.WriteLine("max ="+ b);
    Console.WriteLine("min ="+ a);
}

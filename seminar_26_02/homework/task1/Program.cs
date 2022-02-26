Console.WriteLine("Введите число a: ");
string strValue1 = Console.ReadLine();
int a = int.Parse(strValue1);

Console.WriteLine("Введите число b: ");
string strValue2 = Console.ReadLine();
int b = int.Parse(strValue2);

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

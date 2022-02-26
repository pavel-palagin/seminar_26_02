//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число a: ");
string strNumberA = Console.ReadLine();
int a = int.Parse(strNumberA);

Console.WriteLine("Введите число b: ");
string strNumberB = Console.ReadLine();
int b = int.Parse(strNumberB);

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

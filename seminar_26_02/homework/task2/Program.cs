// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число a: ");
string strNumberA = Console.ReadLine();
int a = int.Parse(strNumberA);

Console.WriteLine("Введите число b: ");
string strNumberB = Console.ReadLine();
int b = int.Parse(strNumberB);

Console.WriteLine("Введите число b: ");
string strNumberC = Console.ReadLine();
int c = int.Parse(strNumberC);

int max = a;

if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.Write(max);

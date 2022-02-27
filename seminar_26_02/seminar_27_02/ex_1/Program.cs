// 1. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число => ");
string strValue = Console.ReadLine();
int a = int.Parse(strValue);

int a = a % 10;

Console.Write(a);

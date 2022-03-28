// 1. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите число a: ");
string strValue = Console.ReadLine();
int a = int.Parse(strValue);

int b = a % 10;

Console.Write(b);

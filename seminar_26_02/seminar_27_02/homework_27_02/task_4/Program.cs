// Задача 4: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

int n = pront("Введите число: ");
int pront(string strValue)
{
    Console.WriteLine(strValue);
    string Value = Console.ReadLine();
    int a = int.Parse(Value);
    return a;
}

if (n > 0 & n < 6) Console.WriteLine("Будний день");
if (n == 6 | n == 7) Console.WriteLine("Выходной день");
if (n > 7) Console.WriteLine("В неделе 7 дней");
if (n < 0) Console.WriteLine("Только положительные значения!!!");

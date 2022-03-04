// Задача 3: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//Console.Write("Type a number : ");
//string number = Console.ReadLine();
//int index = 2;
//if (index < 2) Console.WriteLine("Нет 3ей цифры");
//else Console.WriteLine(number[index]);

int n = pront("Введите число: ");
int pront(string strValue)
{
    Console.WriteLine(strValue);
    string Value = Console.ReadLine();
    int a = int.Parse(Value);
    return a;
}


if (n < 100) Console.WriteLine("Третьей цифры нет");
if (n > 99 && n < 1000) Console.WriteLine("Третья цифра введенного числа: " + n%10);
if (n > 999 && n < 10000) Console.WriteLine("Третья цифра введенного числа: " + n/10%10);
if (n > 9999 && n < 100000) Console.WriteLine("Третья цифра введенного числа: " + n/100%10);
if (n > 99999 && n < 1000000) Console.WriteLine("Третья цифра введенного числа: " + n/1000%10);
if (n > 999999 && n < 10000000) Console.WriteLine("Третья цифра введенного числа: " + n/10000%10);
if (n > 9999999 && n < 100000000) Console.WriteLine("Третья цифра введенного числа: " + n/100000%10);

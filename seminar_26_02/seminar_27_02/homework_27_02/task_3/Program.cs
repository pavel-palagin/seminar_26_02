// Задача 3: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
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
if (n > 9999 && n < 100000) Console.WriteLine("Третья цифра введенного числа: " + n/10/10%10);
if (n > 99999 && n < 1000000) Console.WriteLine("Третья цифра введенного числа: " + n/10/10/10%10);
if (n > 999999 && n < 10000000) Console.WriteLine("Третья цифра введенного числа: " + n/10/10/10/10%10);
if (n > 9999999 && n < 100000000) Console.WriteLine("Третья цифра введенного числа: " + n/10/10/10/10/10%10);
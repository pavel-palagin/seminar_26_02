// Задача 3: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len > 2) Console.WriteLine("Третья цифра введенного числа: " + number[2]);
else Console.WriteLine("Третьей цифры нет");






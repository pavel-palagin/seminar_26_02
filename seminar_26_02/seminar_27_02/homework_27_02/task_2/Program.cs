// Задача 2: Напишите программу, которая выводит случайное трёхзначное 
//число и удаляет вторую цифру этого числа.

Random rnd = new Random();

int value = rnd.Next(99, 999);

Console.WriteLine(value);

int a = value / 100;
int c = value % 10;

Console.Write(a);
Console.Write(c);


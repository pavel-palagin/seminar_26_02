// 3. Напишите программу, которая выводит случайное число из отрезка 
// [10, 99] и показывает наибольшую цифру числа.

Random rnd = new Random();

int value = rnd.Next(10, 99);

int result = value % 10;
int dif = value / 10;

Console.WriteLine(value);

if (result > dif) Console.WriteLine(result); 
else Console.WriteLine(dif); 




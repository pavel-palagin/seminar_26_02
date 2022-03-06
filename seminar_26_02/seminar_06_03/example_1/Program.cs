// Задача 1: Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти => ");
string inputNumber = Console.ReadLine();
int number = int.Parse(inputNumber);

if (number < 1 || number > 4) Console.WriteLine("Всего 4 четверти");
if (number == 1) Console.WriteLine("Диапазон возможных координат точек в этой четверти x > 0 и y > 0");
if (number == 2) Console.WriteLine("Диапазон возможных координат точек в этой четверти x < 0 и y > 0");
if (number == 3) Console.WriteLine("Диапазон возможных координат точек в этой четверти x < 0 и y < 0");
if (number == 4) Console.WriteLine("Диапазон возможных координат точек в этой четверти x > 0 и y < 0");
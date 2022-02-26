// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число => ");
string strNumber = Console.ReadLine();
int number = int.Parse(strNumber);

int result = number % 2;

Console.WriteLine(result);

if (result > 0) 
{
    Console.WriteLine("Нет");
}

else
{
    Console.WriteLine("Да");
}
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);

int A = 1;

while (A < N) 
{ 
    if (A % 2 == 0) 
    {
        Console.Write(A + " ");
    }
A++;

}
